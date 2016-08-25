using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Logger.Logging
{
    class DBLogger : LogBase
    {
        string connectionString = (ConfigurationManager.AppSettings["LoggerTarget"]);

        public override void Log(Level level, string message)
        {
            var currentDateTime = DateTime.Now;
            var logMessage = new LogMessage(level, message, currentDateTime);
            string logMessageResult = logMessage.ToString();

            var logSplit = logMessageResult.Split('\t');



                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "INSERT INTO [Table] VALUES(@date,@time,@type,@message)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlParameter paramdate = new SqlParameter("@date", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add(paramdate);

                    SqlParameter paramtime = new SqlParameter("@time", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add(paramtime);

                    SqlParameter paramtype = new SqlParameter("@type", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add(paramtype);

                    SqlParameter parammessage = new SqlParameter("@message", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add(parammessage);

                    cmd.Parameters["@date"].Value = logSplit[0];
                    cmd.Parameters["@time"].Value = logSplit[1];
                    cmd.Parameters["@type"].Value = logSplit[2];
                    cmd.Parameters["@message"].Value = logSplit[3];

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }  
        }
    }
}
