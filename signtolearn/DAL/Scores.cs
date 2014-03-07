using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public static class Scores
    {
        private static String GetSQLConnectionString()
        {   //function to get the connection string used to communicate with the database
            String DBServer = ConfigurationSettings.AppSettings.Get("DatabaseServer")   ;
            String DBName = "SignToLearn";
            String DBUser = "sa";
            String DBPass = "Clasic22";
            return String.Format("user id={0};password={1};server={2};Trusted_Connection=yes;database={3};connection timeout=30; MultipleActiveResultSets=True;", DBUser, DBPass, DBServer, DBName);
        }
    }
}
