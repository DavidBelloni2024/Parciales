using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



namespace SL.DAL.Tools
{
    public static class SqlHelper
    {
        readonly static string ConString;
        static SqlHelper()
        {
            ConString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
        }

        public static Int32 ExecuteNonQuery(String commandText,CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect 
                    // type is only for OLE DB.

                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static Object ExecuteScalar(String commandText,CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuteReader(String commandText,CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(ConString);
            string s = commandText;
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                // When using CommandBehavior.CloseConnection, the connection will be closed when the 
                // IDataReader is closed.
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }


    }
}
