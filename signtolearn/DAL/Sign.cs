using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public static class Sign
    {
        private static String GetSQLConnectionString()
        {
            String DBServer = ConfigurationSettings.AppSettings.Get("DatabaseServer");
            String DBName = "SignToLearn";
            String DBUser = "sa";
            String DBPass = "Clasic22";
            return String.Format("user id={0};password={1};server={2};Trusted_Connection=yes;database={3};connection timeout=30; MultipleActiveResultSets=True;", DBUser, DBPass, DBServer, DBName);
        }

        public static SignInfo GetSignInfo(String UserName, char Letter)
        {   //gets all of the calibrated and uncalibrated info to match a sign
            SqlConnection conn = new SqlConnection(GetSQLConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Percentage, NumFingers, ClosestPoint, Area from Sign INNER JOIN Alphabet on Sign.Letter = Alphabet.Letter where UserName = @username and Sign.Letter = @letter", conn);
            cmd.Parameters.AddWithValue("@username", UserName);
            cmd.Parameters.AddWithValue("@letter", Letter);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            double Percentage = Double.Parse(reader[0].ToString());
            int NumFingers = Int32.Parse(reader[1].ToString());
            double ClosestPoint = Double.Parse(reader[2].ToString());
            double Area = Double.Parse(reader[3].ToString());
            conn.Close();
            return new SignInfo(Letter, UserName, Percentage, NumFingers, ClosestPoint, Area);
        }

        public static void AddSign(char Letter, String UserName, double Area)
        {
            SqlConnection conn = new SqlConnection(GetSQLConnectionString());
            SqlCommand cmd = new SqlCommand("INSERT into Sign (Letter, UserName, Area) VALUES (@letter, @username, @area)", conn);
            cmd.Parameters.AddWithValue("@letter", Letter);
            cmd.Parameters.AddWithValue("@username", UserName);
            cmd.Parameters.AddWithValue("@area", Area);
            cmd.ExecuteScalar();
            conn.Close();
        }
    }

    public class SignInfo : AlphabetInfo
    {
        public SignInfo(char _Letter, String _UserName, double _Percentage, int _NumFingers, double _ClosestPoint, double _Area) : base(_Letter, _NumFingers, _ClosestPoint, _Percentage)
        {
            UserName = _UserName;
            Area = _Area;
        }

        public String UserName { get; private set; }
        public double Area { get; private set; }
    }
}
