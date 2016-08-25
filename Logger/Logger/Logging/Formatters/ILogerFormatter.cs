using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logging.Formatters
{
    interface ILogerFormatter
    {
        string ApplyFormat(LogMessage logMessage);
    }
}
