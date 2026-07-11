using System.Collections.Generic;
using System.Text;

namespace psai.net;

internal class Logger
{
	private static Logger s_instance;

	private StringBuilder m_lastErrorStringBuilder;

	private bool m_lastErrorNewMessageAvailable;

	private List<LoggerOutput> m_loggerOutputs = new List<LoggerOutput>();

	internal static Logger Instance
	{
		get
		{
			if (s_instance == null)
			{
				s_instance = new Logger();
			}
			return s_instance;
		}
		set
		{
			s_instance = value;
		}
	}

	internal LogLevel LogLevel { get; set; }

	internal List<LoggerOutput> LoggerOutputs
	{
		get
		{
			if (m_loggerOutputs.Count == 0)
			{
				m_loggerOutputs.Add(new LoggerOutputUnity());
			}
			return m_loggerOutputs;
		}
		set
		{
			m_loggerOutputs = value;
		}
	}

	internal void Log(string argText, LogLevel logLevel)
	{
		if (logLevel > LogLevel)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("[");
		stringBuilder.Append(Logik.GetTimestampMillisElapsedSinceInitialisation().ToString());
		stringBuilder.Append("]");
		switch (logLevel)
		{
		case LogLevel.info:
			stringBuilder.Append("[INFO]: ");
			break;
		case LogLevel.warnings:
			stringBuilder.Append("[WARNING]: ");
			break;
		case LogLevel.errors:
			stringBuilder.Append("[ERROR]:");
			break;
		case LogLevel.debug:
			stringBuilder.Append("     [INTERNAL]: ");
			break;
		}
		stringBuilder.Append(argText);
		WriteToLoggerOutputs(stringBuilder.ToString(), logLevel);
		if (logLevel == LogLevel.warnings || logLevel == LogLevel.errors)
		{
			if (m_lastErrorStringBuilder == null || !m_lastErrorNewMessageAvailable)
			{
				m_lastErrorStringBuilder = new StringBuilder();
			}
			m_lastErrorStringBuilder.AppendLine(argText);
			m_lastErrorNewMessageAvailable = true;
		}
	}

	internal void WriteToLoggerOutputs(string message, LogLevel logLevel)
	{
		foreach (LoggerOutput loggerOutput in LoggerOutputs)
		{
			loggerOutput.WriteLog(message, logLevel);
		}
	}

	internal string GetLastError()
	{
		if (m_lastErrorNewMessageAvailable)
		{
			m_lastErrorNewMessageAvailable = false;
			return m_lastErrorStringBuilder.ToString();
		}
		return null;
	}
}
