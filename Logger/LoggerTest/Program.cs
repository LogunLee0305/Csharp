using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace LoggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyLogger.Log(Level.Info, "Write First Log");
                MyLogger.Log(Level.Error, "Write 2 Log");
                MyLogger.Log(Level.Warning, "Write 3 Log");
            }

            catch { }
        }
    }
}
