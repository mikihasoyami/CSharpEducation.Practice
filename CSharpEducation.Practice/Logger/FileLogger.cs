using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Logger
{
    public class FileLogger : ILogger
    {
        private readonly string FilePath;
        public FileLogger(string FilePath)
        {
            FilePath = FilePath;
        }

        public void Trace(string Message) => Log(Message, LogLevel.Trace);
        public void Info(string Message) => Log(Message, LogLevel.Info);
        public void Debug(string Message) => Log(Message, LogLevel.Debug);
        public void Warning(string Message) => Log(Message, LogLevel.Warning);
        public void Error(string Message) => Log(Message, LogLevel.Error);
        public void Fatal(string Message) => Log(Message, LogLevel.Fatal);

        public void Log(string Message, LogLevel Level)
        {
            string LogMessage = FormatMessage(Message, Level);
            using (StreamWriter Writer = new StreamWriter(LogMessage))
                Writer.WriteLine(LogMessage);
        }

        private string FormatMessage(string message, LogLevel Level)
        {
            return $"{DateTime.Now} | {GetType().Name} | {Level} | {message}";
        }
    }
}
