using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public static class User
    {
        private static String GetSQLConnectionString()
        {
            String DBUser = "sa";
            String DBPass = "Clasic22";
            throw new NotImplementedException();
        }

        public static List<String> GetUserNames()
        {
            List<String> retVal = new List<String>();
            SqlConnection Conn = new SqlConnection(GetSQLConnectionString());
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserName from User", Conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                retVal.Add(reader[0].ToString());
            }

            Conn.Close();
            return retVal;
        }

        public static String GetFirstName(String UserName)
        {
            SqlConnection Conn = new SqlConnection(GetSQLConnectionString());
            Conn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT FirstName from User WHHERE UserName = '{0}'", UserName), Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String retVal = reader[0].ToString();
            Conn.Close();
            return retVal;
        }
    }
}
