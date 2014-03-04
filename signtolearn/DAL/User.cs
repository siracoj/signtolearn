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
            String DBServer = ConfigurationSettings.AppSettings.Get("DatabaseServer");
            String DBName = "SignToLearn";
            String DBUser = "sa";
            String DBPass = "Clasic22";
            return String.Format("user id={0};password={1};server={2};Trusted_Connection=yes;database={3};connection timeout=30; MultipleActiveResultSets=True;", DBUser, DBPass, DBServer, DBName);
        }

        public static List<String> GetUserNames()
        {   //this function would be good to use to populate a login screen of user names
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
        {   //this function can get the first name of someone based on their user name. can be used for like a welcome screen or something when they log in
            SqlConnection Conn = new SqlConnection(GetSQLConnectionString());
            Conn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT FirstName from User WHHERE UserName = '{0}'", UserName), Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String retVal = reader[0].ToString();
            Conn.Close();
            return retVal;
        }

        public static char GetProgress(String UserName)
        {   //this function gets the current progress the user has calibrated to. check if they are fully calibrated before letting them progress
            SqlConnection Conn = new SqlConnection(GetSQLConnectionString());
            Conn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT TrainingProgress from User WHHERE UserName = '{0}'", UserName), Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            char retVal = char.Parse(reader[0].ToString());
            Conn.Close();
            return retVal;
        }
    }
}
