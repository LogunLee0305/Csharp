using Logger.Logging.Formatters;
using System;

namespace Logger.Logging
{
    public class LogMessage
    {
        public Level Level { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }

        public LogMessage(Level level, string text, DateTime dateTime)
        {
            Level = level;
            Text = text;
            DateTime = dateTime;
        }

        public override string ToString()
        {
            return new DefaultLoggerFormatter().ApplyFormat(this);
        }
    }
}
