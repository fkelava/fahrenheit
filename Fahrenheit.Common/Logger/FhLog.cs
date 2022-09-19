using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Fahrenheit.Common.Logger;

public enum LogLevel
{
    Trace       = 0,
    Debug       = 1,
    Information = 2,
    Warning     = 3,
    Error       = 4,
    Critical    = 5,
    None        = 6
}

public static class FhLog
{
#if DEBUG
    private const LogLevel MinLevel = LogLevel.Debug;
#else
    private const LogLevel MinLevel = LogLevel.Information;
#endif

    static FhLog()
    {
        try
        {
            Directory.CreateDirectory("../log");

            Trace.AutoFlush = true;
            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.Listeners.Add(new TextWriterTraceListener(File.OpenWrite($"../log/{GetTimestampString()}.log")));
        }
        catch (Exception ex)
        {
            Trace.WriteLine(@"WARNING! Trace failed to start. Logging will be console-only for this session.");
            Trace.WriteLine($"StackTrace: {ex.StackTrace}");
            Trace.WriteLine($"Message: {ex.Message}");
        }

        Trace.WriteLine($"{UnixMillisUtc()} | This is Fahrenheit.Core.");
    }

    public static void Log(LogLevel                  level,
                           string                    msg,
                           [CallerMemberName] string mname = "",
                           [CallerFilePath]   string fpath = "",
                           [CallerLineNumber] int    lnb   = 0)
    {
        if (level < MinLevel)
            return;

        Trace.WriteLine($"{UnixMillisUtc()} | [{level}] {Path.GetFileName(fpath)}:{lnb} ({mname}): {msg}");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long UnixMillisUtc()
    {
        return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }

    public static string GetTimestampString()
    {
        DateTime dt = DateTime.UtcNow;

        return $"{dt.Day:D2}{dt.Month:D2}{dt.Year:D2}_{dt.Hour:D2}{dt.Minute:D2}{dt.Second:D2}";
    }
}