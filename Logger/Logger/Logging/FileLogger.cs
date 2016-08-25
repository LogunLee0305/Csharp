using System.IO;
using System.Configuration;
using System;

namespace Logger.Logging
{
    class FileLogger : LogBase
    {
        private string filePath = ConfigurationManager.AppSettings["LoggerTarget"];
        public override void Log(Level level, string message)
        {
            var currentDateTime = DateTime.Now;
            var logMessage = new LogMessage(level, message, currentDateTime);

                using (var writer = new StreamWriter(File.Open(filePath, FileMode.Append)))
                    writer.WriteLine(logMessage);
                    
        }
    }
}
