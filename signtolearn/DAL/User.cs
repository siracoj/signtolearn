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
            try
            {
                
                SqlConnection Conn = new SqlConnection(GetSQLConnectionString());
                Conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserName from [User]", Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    retVal.Add(reader[0].ToString());
                }
                Conn.Close();
                return retVal;
            }
            catch (SqlException e)
            {
                retVal.Add("Error could not connect");
                return retVal;
                //maybe a could not connect message here?
            }
        }

        public static String GetName(String UserName)
        {   //this function can get the first name of someone based on their user name. can be used for like a welcome screen or something when they log in
            SqlConnection Conn = new SqlConnection(GetSQLConnectionString());
            Conn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT FirstName, LastName from [User] WHERE UserName = '{0}'", UserName), Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String retVal = String.Format("{0} {1}", reader[0].ToString(), reader[1].ToString());
            Conn.Close();
            return retVal;
        }

        public static char GetProgress(String UserName)
        {   //this function gets the current progress the user has calibrated to. check if they are fully calibrated before letting them progress
            try
            {
                SqlConnection Conn = new SqlConnection(GetSQLConnectionString());
                Conn.Open();
                SqlCommand cmd = new SqlCommand(String.Format("SELECT TrainingProgress from [User] WHERE UserName = '{0}'", UserName), Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                char retVal = char.Parse(reader[0].ToString());
                Conn.Close();
                return retVal;
            }
            catch (SqlException e)
            {
                //not sure what to do here, but we need try catches
                Environment.Exit(0);
                return '0';
            }
        }

        public static bool AddProfile(String UserName, String FirstName, String LastName)
        {
            if (GetUserNames().Contains(UserName))
                return false;
            try
            {
                SqlConnection conn = new SqlConnection(GetSQLConnectionString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT into [User] (UserName, FirstName, LastName, TrainingProgress) VALUES (@username, @firstname, @lastname, 'A')", conn);
                cmd.Parameters.AddWithValue("@username", UserName);
                cmd.Parameters.AddWithValue("@firstname", FirstName);
                cmd.Parameters.AddWithValue("@lastname", LastName);
                cmd.ExecuteScalar();
                conn.Close();
                return true;
            }
            catch (SqlException e)
            {
                //not sure what to do here, but we need try catches
                Environment.Exit(0);
                return false;
            }
        }
    }
}
