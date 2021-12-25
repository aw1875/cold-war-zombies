using System;
using System.IO;

namespace BigK.Common
{
    enum LogEvent
    {
        Info = 0,
        Success = 1,
        Warning = 2,
        Error = 3
    }

    internal static class Log
    {
        private static readonly string LogSession = DateTime.Now.ToLocalTime().ToString("ddMMyyyy_HHmmss");
        private static readonly string LogPath = AppDomain.CurrentDomain.BaseDirectory + "logs";

        internal static void Write(LogEvent Level, string Message)
        {
            string Event = string.Empty;

            switch (Level)
            {
                case LogEvent.Info:
                    Event = "INFO";
                    break;
                case LogEvent.Success:
                    Event = "SUCCESS";
                    break;
                case LogEvent.Warning:
                    Event = "WARNING";
                    break;
                case LogEvent.Error:
                    Event = "ERROR";
                    break;
            }

            if (!Directory.Exists(LogPath))
            {
                Directory.CreateDirectory(LogPath);
            }

            File.AppendAllText(LogPath + @"\" + LogSession, string.Format("[{0}] => {1}: {2}\n", DateTime.Now.ToString("HH:mm:ss"), Event, Message));
        }
    }
}