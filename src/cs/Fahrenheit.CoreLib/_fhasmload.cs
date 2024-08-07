﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Text.Json;

namespace Fahrenheit.CoreLib;

public static class FhLoader
{
    public static List<Assembly> LoadedPluginAssembliesCache { get; } = new List<Assembly>();

    /// <summary>
    ///     Loosely infers whether a module _could_ be a valid Fahrenheit module. It does so by checking whether the plugin has a .runtimeconfig.json and .deps.json file.
    /// <para></para>
    ///     This is because a properly exported plugin will mark &lt;EnableDynamicLoading&gt;true&lt;/EnableDynamicLoading&gt; in its project, hence have a *.runtimeconfig.json and *.deps.json.
    /// </summary>
    private static bool IsModule(string dirEntry)
    {
        return dirEntry.EndsWith(".dll")
               && File.Exists(dirEntry.Replace(".dll", ".runtimeconfig.json"))
               && File.Exists(dirEntry.Replace(".dll", ".deps.json"));
    }

    private static bool IsAssemLoaded(string refAssemName)
    {
        foreach (Assembly loadedAssembly in LoadedPluginAssembliesCache)
        {
            if (loadedAssembly.GetName().Name?.ToUpperInvariant() == refAssemName)
                return true;
        }

        return false;
    }

    /// <summary>
    ///     Loosely infers whether a referenced assembly <i>should</i> be loaded by Fahrenheit instead of being lazy-loaded by the .NET runtime.
    /// </summary>
    private static bool ResolveModuleRef(string dirPath, string refAssemName, out string refAssemFullPath)
    {
        refAssemFullPath = Path.Join(dirPath, $"{refAssemName}.dll");

        return File.Exists(refAssemFullPath) && !IsAssemLoaded(refAssemName);
    }

    /// <summary>
    ///     Loads a module while ensuring its references, if detected, are loaded before it.
    /// </summary>
    private static bool LoadSingleModule(string fullPath, [NotNullWhen(true)] out List<FhModuleConfigCollection>? moduleConfigCollections)
    {
        moduleConfigCollections = new List<FhModuleConfigCollection>();

        string dirName        = Path.GetDirectoryName(fullPath) ?? throw new Exception("FH_E_MODULE_DIR_UNIDENTIFIABLE");
        string moduleName     = Path.GetFileNameWithoutExtension(fullPath).ToUpperInvariant();
        string configJsonName = Path.Join(FhRuntimeConst.ConfigDir.Path, Path.GetFileName(fullPath).Replace(".dll", ".conf.json"));

        bool shouldLoadConfig = File.Exists(configJsonName);

        if (IsAssemLoaded(moduleName))
        {
            FhLog.Log(LogLevel.Info, $"{moduleName} already loaded; skipping.");
            return true;
        }

        FhLog.Log(LogLevel.Info, $"Loading module {moduleName}.");

        AssemblyLoadContext asmLoadCtx            = AssemblyLoadContext.GetLoadContext(typeof(FhLoader).Assembly) ?? throw new Exception("E_CANNOT_GET_OWN_ALC");
        Assembly            currentlyLoadingAssem = asmLoadCtx.LoadFromAssemblyPath(fullPath);

        LoadedPluginAssembliesCache.Add(currentlyLoadingAssem);

        // --> LOAD ORDERING; LOAD REFERENCED ASSEMBLIES FIRST <--
        foreach (AssemblyName refAssem in currentlyLoadingAssem.GetReferencedAssemblies())
        {
            if (ResolveModuleRef(dirName, refAssem.Name ?? throw new Exception("FH_E_REF_ASSEM_NAME_NULL"), out string refAssemFullPath))
            {
                FhLog.Log(LogLevel.Info, $"{moduleName} depends on {refAssem.Name.ToUpperInvariant()}; trying to load it first.");

                if (!LoadSingleModule(refAssemFullPath, out List<FhModuleConfigCollection>? refAssemConfigCollection))
                    throw new Exception("FH_E_REF_ASSEM_LOAD_FAULT");

                moduleConfigCollections.AddRange(refAssemConfigCollection);
            }
        }
        // --> END LOAD ORDERING <--

        // --> LOAD CONFIGURATIONS <--
        if (shouldLoadConfig)
        {
            string patchedJson = File.ReadAllText(configJsonName).ApplyRuntimeConstDirRedirects();

            FhModuleConfigCollection configCollection =
                JsonSerializer.Deserialize<FhModuleConfigCollection>(patchedJson, FhUtil.JsonOpts) ??
                throw new Exception($"FH_E_CONF_DESERIALIZE_FAULT: {moduleName}.");

            FhLog.Log(LogLevel.Info, $"{moduleName} loaded successfully, parsing {configCollection.ModuleConfigs.Count.ToString()} configurations.");

            moduleConfigCollections.Add(configCollection);
        }
        else FhLog.Log(LogLevel.Info, $"{moduleName} loaded successfully.");
        // --> END LOAD CONFIGURATIONS <--

        return true;
    }

    /// <summary>
    ///     Loads and instantiates all eligible modules in the module directory.
    ///     An eligible module has a defined configuration named *.conf.json.
    ///     Referenced modules are also resolved and loaded at the same time if required.
    /// </summary>
    public static bool LoadModules(string dirPath, [NotNullWhen(true)] out List<FhModuleConfigCollection>? moduleConfigCollections)
    {
        moduleConfigCollections = new List<FhModuleConfigCollection>();

        foreach (string dirEntry in Directory.EnumerateFiles(dirPath))
        {
            if (!IsModule(dirEntry) || !LoadSingleModule(dirEntry, out List<FhModuleConfigCollection>? singleModuleConfigCollection)) continue;
            moduleConfigCollections.AddRange(singleModuleConfigCollection);
        }

        return true;
    }

    /// <summary>
    ///     Replaces instances of well-known directory substitution strings in a config JSON being loaded
    ///     with the actual locations of these directories. This is provided so you can use the same, well-defined
    ///     file path relative to the binary for any file across all supported platforms.
    /// <para></para>
    ///     e.g. $resdir (Linux) -> /opt/fahrenheit/resources, $resdir (Windows) -> C:\Users\USER1\fahrenheit\resources
    /// <para></para>
    ///     For the actual directories and how they are computed, see <see cref="FhRuntimeConst"/>.
    /// </summary>
    internal static string ApplyRuntimeConstDirRedirects(this string configJson)
    {
        foreach (FieldInfo field in typeof(FhRuntimeConst).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            if (field.FieldType == typeof(FhDirLink))
            {
                FhDirLink? dirLink = field.GetValue(null) as FhDirLink ?? throw new Exception("FH_E_DIR_LINK_FAULT");
                configJson = configJson.Replace(dirLink.LinkSymbol, dirLink.Path);
            }
        }

        return configJson;
    }

    /* [fkelava 27/2/23 00:12]
     * In systems such as ours where JSON-serialized objects contain their full type name
     * to allow for polymorphic deserialization, we must prevent the spawning of arbitrary types.
     *
     * These methods take the "Type" variable of a given JSON configuration and try to resolve it
     * to an actual Type instance while making sure that it not only exists, but is what we expect-
     * usually a derived type of FhModuleConfig.
     */
    public static bool StrictResolveDescendantOf<T>(this ref Utf8JsonReader reader,
                                                    Type                    typeToConvert,
                                                    out Type                actualType)
    {
        string typename = reader.DeserializeAndAdvance<string>("Type");

        foreach (Assembly assembly in LoadedPluginAssembliesCache)
        {
            foreach (Type type in assembly.GetExportedTypes())
            {
                if (type.FullName != typename || !typeof(T).IsAssignableFrom(type) || type == typeof(T)) continue;

                if (!typeToConvert.IsAssignableFrom(type))
                {
                    throw new JsonException($"E_TYPE_MISMATCH: {typeToConvert.FullName} is not assignable from {type.FullName}.");
                }

                actualType = type;
                return true;
            }
        }

        throw new JsonException($"E_TYPE_NOTFOUND: type {typename} was not found in any loaded assembly. Check your configuration.");
    }

    public static bool StrictResolveExactType<T>(this ref Utf8JsonReader reader,
                                                 Type                    typeToConvert,
                                                 out Type                actualType)
    {
        string typename = reader.DeserializeAndAdvance<string>("Type");

        foreach (Assembly assembly in LoadedPluginAssembliesCache)
        {
            foreach (Type type in assembly.GetTypes())
            {
                if (type.FullName != typename || type != typeof(T)) continue;

                if (type != typeToConvert)
                {
                    throw new JsonException($"E_TYPE_MISMATCH: expected {typeToConvert.FullName} but got {type.FullName}");
                }

                actualType = type;
                return true;
            }
        }

        throw new JsonException($"E_TYPE_NOTFOUND: type {typename} was not found in any loaded assembly. Check your configuration.");
    }
}