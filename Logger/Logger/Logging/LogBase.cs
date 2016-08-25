using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logging 
{
    public abstract class LogBase
    {
        public abstract void Log(Level level, string message);
    }
}
