using System.Dynamic;

namespace Logger
{
    public enum LogLevel
    {
        Trace,
        Info,
        Debug,
        Warning,
        Error,
        Fatal
    }

    public interface ILogger
    {
        void Trace(string Message);
        void Info(string Message);
        void Debug(string Message);
        void Warning(string Message);
        void Error(string Message);
        void Fatal(string Message);
        void Log(string Message, LogLevel Level);
    }
}
