using System;
using System.Diagnostics;
using System.IO;

namespace psai.net;

internal class LoggerOutputWindows : LoggerOutput
{
	internal static readonly string PSAI_FILENAME_LOGFILE = "psai.log";

	internal LoggerOutputWindows()
	{
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "psai");
		if (!File.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		TextWriterTraceListener listener = new TextWriterTraceListener(File.Create(Path.Combine(text, PSAI_FILENAME_LOGFILE)));
		Trace.Listeners.Add(listener);
	}

	public void WriteLog(string argMessage, LogLevel logLevel)
	{
	}
}
