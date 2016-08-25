using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace DataImport
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            var dbc = new Add_DB();
            string filepath = dbc.GetPath(args[0]); //현재 디렉토리 + args[0]
 
            if (dbc.CSVtoSQL(filepath, connStr))
                {
                    Console.WriteLine("Data Import 성공");
                }
        }
    }
}
