using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace DataImport
{
    class Add_DB
    {
        public string GetPath(string CSVfilename)
        {
            string currentpath = Directory.GetCurrentDirectory();
            string Fullpath = currentpath + "\\" + CSVfilename;
            return Fullpath;
        }

        public bool CSVtoSQL(string filepath, string connStr)
        {
            using (DataSet ds = new DataSet())
            {
                SqlConnection conn = new SqlConnection(connStr);
                    //
                    // Open the SqlConnection,
                    //
                    conn.Open();
                //
                // The following code uses an Sqlcommand based on the SqlConnection.
                //

                string sql = "IF NOT EXISTS(SELECT Product FROM import WHERE Product=@product) INSERT import VALUES(@id,@product,@price) else UPDATE import SET Price = @price, Id =@id WHERE Product =@product";


                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlParameter paramid = new SqlParameter("@id", SqlDbType.Int);
                cmd.Parameters.Add(paramid);

                SqlParameter paramproduct = new SqlParameter("@product", SqlDbType.NChar, 10);
                cmd.Parameters.Add(paramproduct);

                SqlParameter paramprice = new SqlParameter("@price", SqlDbType.Float);
                cmd.Parameters.Add(paramprice);

                StreamReader sr = new StreamReader(filepath);
                string[] value;

                while (!sr.EndOfStream)
                {

                    value = sr.ReadLine().Split(',');
                   
                    cmd.Parameters["@id"].Value = value[0];                
                    cmd.Parameters["@product"].Value = value[1];                            
                    cmd.Parameters["@price"].Value = value[2];
                   
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
                }
                return true;
        }
    }
}
