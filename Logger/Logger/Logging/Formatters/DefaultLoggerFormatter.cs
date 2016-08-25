using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logging.Formatters
{
    class DefaultLoggerFormatter : ILogerFormatter
    {
        public string ApplyFormat(LogMessage logMessage)
        {
            return string.Format("{0:yyyy-mm-dd\tHH:mm:ss}\t{1,-10}\t{2}",
                         logMessage.DateTime, logMessage.Level, logMessage.Text);
        }
    }
}
