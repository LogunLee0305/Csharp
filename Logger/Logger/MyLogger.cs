using Logger.Logging;
using System;
using System.Configuration;

namespace Logger
{
    public static class MyLogger
    {
        private static LogBase logger = null;

        static MyLogger()
        {
            switch (ConfigurationManager.AppSettings["LoggerType"])
            {
                case "FileLogger":
                    logger = new FileLogger();
                    break;
                case "DBLogger":
                    logger = new DBLogger();
                    break;
                case "JsonLogger":
                    logger = new JsonLogger();
                    break;
                default:
                    throw new Exception("logger 가 null 입니다.");
            }
        }
        public static void Log(Level level, string message)
        {
            logger.Log(level, message);
        }
    }
}
