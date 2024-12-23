    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PokeDexApp
{
    public class DBConnect
    {
        public string connectionString;
        public SqlConnection conn;

        public DBConnect()
        {
            try
            {
                connectionString = "Data Source=Lucas_pc;Initial Catalog=PokeDex;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                conn = new(connectionString);
                conn.Open();
            }

            catch (Exception ex)
            {
                throw new(ex.Message);
            }
        }

        public DataTable SQLCommand(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                if (conn.State == 0)
                {
                    conn.Open();
                }

                var selectCommand = new SqlCommand(query, conn);
                selectCommand.CommandTimeout = 0;
                var redaer = selectCommand.ExecuteReader();
                dt.Load(redaer);
            }

            catch (Exception ex)
            {
                throw new(ex.Message);
            }
            conn.Close();
            return dt;
        }

        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (conn.State == 0)
                {
                    conn.Open();
                }

                dbCommand.Connection = conn;
                dbCommand.CommandType = CommandType.Text;
                int rows = dbCommand.ExecuteNonQuery();
                conn.Close();
                return rows;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
