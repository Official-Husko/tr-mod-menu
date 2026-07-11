using UnityEngine;

namespace psai.net;

internal class LoggerOutputUnity : LoggerOutput
{
	internal LoggerOutputUnity()
	{
	}

	~LoggerOutputUnity()
	{
	}

	public void WriteLog(string argMessage, LogLevel logLevel)
	{
		string text = "PSAI " + argMessage;
		switch (logLevel)
		{
		case LogLevel.errors:
			Debug.LogError((object)text);
			break;
		case LogLevel.warnings:
			Debug.LogWarning((object)text);
			break;
		default:
			Debug.Log((object)text);
			break;
		}
	}
}
