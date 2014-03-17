using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class User
    {
        public static List<String> GetUserNames()
        {   //function that returns all user names in the database
            List<String> retVal = new List<String>();
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable rawUserData = new DataTable();

            String cmd = String.Format("SELECT * from User");
            rawUserData = db.GetDataTable(cmd);

            foreach (DataRow r in rawUserData.Rows)
            {
                retVal.Add(r["UserName"].ToString());
            }
            return retVal;
        }

        public static bool SetProgress(String UserName, char Letter)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> data = new Dictionary<string, string>();
            data.Add("TrainingProgress", Char.ToString(Letter));
            return db.Update("User", data, String.Format("UserName = '{0}'", UserName));
        }

        public static String GetName(String UserName)
        {   //gets a users first and last name from the database
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable rawUserData = new DataTable();

            String cmd = String.Format("SELECT * from User WHERE UserName = '{0}'", UserName);
            rawUserData = db.GetDataTable(cmd);

            String retVal = rawUserData.Rows[0]["FirstName"].ToString() + " " + rawUserData.Rows[0]["LastName"].ToString();
            return retVal;
        }

        public static char GetProgress(String UserName)
        {   //gets a useres training progress from the database
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable rawUserData = new DataTable();

            String cmd = String.Format("SELECT * from User WHERE UserName = '{0}'", UserName);
            rawUserData = db.GetDataTable(cmd);

            char retVal = char.Parse(rawUserData.Rows[0]["TrainingProgress"].ToString());
            return retVal;
        }

        public static bool AddProfile(String UserName, String FirstName, String LastName)
        {   //adds a new user profile to the database
            if (GetUserNames().Contains(UserName))
                return false;

            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> data = new Dictionary<string, string>();

            data.Add("UserName", UserName);
            data.Add("FirstName", FirstName);
            data.Add("LastName", LastName);
            data.Add("TrainingProgress", "A");

            db.Insert("User", data);
            return true;
        }
        public static void DeleteProfile(String UserName)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            db.Delete("Sign", String.Format("UserName = '{0}'", UserName));
            db.Delete("User", String.Format("UserName = '{0}'", UserName));
        }
    }
}
