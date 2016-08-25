using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;
using System.IO;

namespace Logger.Logging
{
    class JsonLogger : LogBase
    {
        private string filePath = ConfigurationManager.AppSettings["LoggerTarget"];

        public override void Log(Level level, string message)
        {
            var currentDateTime = DateTime.Now;
            var logMessage = new LogMessage(level, message, currentDateTime);
            string logMessageResult = logMessage.ToString();

            var logSplit = logMessageResult.Split('\t');
            var log = new LogList { Date = logSplit[0], Time = logSplit[1], Type = logSplit[2], Message = logSplit[3] };

            string jsonString = JsonConvert.SerializeObject(log);

       
                using (var writer = new StreamWriter(File.Open(filePath, FileMode.Append)))
                    writer.WriteLine(jsonString);                
        }
    }

    class LogList
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
    }
}
