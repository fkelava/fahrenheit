﻿using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Fahrenheit.CoreLib;

public enum LogLevel
{
    Trace   = 0,
    Debug   = 1,
    Info    = 2,
    Warning = 3,
    Error   = 4,
    Fatal   = 5,
    None    = 6
}

public static class FhLog
{
#if DEBUG
    private const LogLevel MinLevel = LogLevel.Debug;
#else
    private const LogLevel MinLevel = LogLevel.Info;
#endif

    static FhLog()
    {
        Trace.AutoFlush = true;
        Trace.Listeners.Add(new ConsoleTraceListener());
        Trace.Listeners.Add(new TextWriterTraceListener(File.Open(Path.Join(FhRuntimeConst.DiagLogDir.Path, "latest.log"), FileMode.Create, FileAccess.Write, FileShare.Read)));
    }

    public static void Log(LogLevel                  level,
                           string                    msg,
                           [CallerMemberName] string mname = "",
                           [CallerFilePath]   string fpath = "",
                           [CallerLineNumber] int    lnb   = 0)
    {
        if (level < MinLevel) return;
        
		string timeFormat = @"hh:mm:ss.ff t\M";
        string time = DateTimeOffset.UtcNow.ToString(timeFormat);
		string prefix = $"{time} | [{level}] {Path.GetFileName(fpath)}:{lnb}";

		if (msg.Contains('\n')) {
			string newline_prefix = "".PadLeft(prefix.Length, ' ');
			msg = msg.Replace("\r", "");
			msg = msg.Replace("\n", $"\n{newline_prefix}\t| ");
		}

        Trace.WriteLine($"{prefix}\t| {msg}");
    }

	public static void Debug(string msg,
							 [CallerMemberName] string mname = "",
							 [CallerFilePath] string fpath = "",
							 [CallerLineNumber] int lnb = 0) {
		Log(LogLevel.Debug, msg, mname, fpath, lnb);
	}

	public static void Info(string msg,
						    [CallerMemberName] string mname = "",
							[CallerFilePath] string fpath = "",
							[CallerLineNumber] int lnb = 0) {
		Log(LogLevel.Info, msg, mname, fpath, lnb);
	}

	public static void Warning(string msg,
							   [CallerMemberName] string mname = "",
							   [CallerFilePath] string fpath = "",
							   [CallerLineNumber] int lnb = 0) {
		Log(LogLevel.Warning, msg, mname, fpath, lnb);
	}

	public static void Error(string msg,
							 [CallerMemberName] string mname = "",
							 [CallerFilePath] string fpath = "",
							 [CallerLineNumber] int lnb = 0) {
		Log(LogLevel.Error, msg, mname, fpath, lnb);
	}

	public static void Fatal(string msg,
							 [CallerMemberName] string mname = "",
							 [CallerFilePath] string fpath = "",
							 [CallerLineNumber] int lnb = 0) {
		Log(LogLevel.Fatal, msg, mname, fpath, lnb);
	}
}