namespace psai.net;

public interface LoggerOutput
{
	void WriteLog(string argMessage, LogLevel logLevel);
}
