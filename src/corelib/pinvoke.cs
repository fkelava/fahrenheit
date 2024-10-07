﻿namespace Fahrenheit.CoreLib;

/* [fkelava 6/6/23 21:29]
 * Vararg P/Invokes must be declared assembly-local due to https://github.com/dotnet/runtime/issues/87188.
 */

internal static unsafe partial class FhPInvoke {
    internal const uint INFINITE = 4294967295;

    [LibraryImport("kernelbase.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static partial bool WaitOnAddress(void* Address, void* CompareAddress, nint AddressSize, uint dwMilliseconds);

    [LibraryImport("kernelbase.dll", SetLastError = true)]
    internal static partial void WakeByAddressSingle(void* Address);

    [LibraryImport("kernelbase.dll", SetLastError = true)]
    internal static partial void WakeByAddressAll(void* Address);

    [LibraryImport("kernel32.dll", EntryPoint = "GetModuleHandleW", StringMarshalling = StringMarshalling.Utf16)]
    internal static partial nint GetModuleHandle(string? lpModuleName);

    [LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Custom, StringMarshallingCustomType = typeof(System.Runtime.InteropServices.Marshalling.AnsiStringMarshaller))]
    internal static partial nint GetProcAddress(nint hModule, string lpProcName);

#if DEBUG
    private const string hook_lib_name = "minhook.x32d.dll";
#else
    private const string hook_lib_name = "minhook.x32.dll";
#endif

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_Initialize();

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_Uninitialize();

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_CreateHook(
            nint pTarget,
            nint pDetour,
        ref nint ppOriginal);

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_CreateHookApi(
        [MarshalAs(UnmanagedType.LPWStr)] string pszModule,
        [MarshalAs(UnmanagedType.LPStr)]  string pszProcName,
                                          nint   pDetour,
                                      ref nint   ppOriginal);

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_CreateHookApiEx(
        [MarshalAs(UnmanagedType.LPWStr)] string pszModule,
        [MarshalAs(UnmanagedType.LPStr)]  string pszProcName,
                                          nint   pDetour,
                                      ref nint   ppOriginal,
                                      ref nint   ppTarget);

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_EnableHook(nint pTarget);

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_RemoveHook(nint pTarget);

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_DisableHook(nint pTarget);

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_QueueEnableHook(nint pTarget);

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_QueueDisableHook(nint pTarget);

    [LibraryImport(hook_lib_name)]
    internal static partial int MH_ApplyQueued();
}
