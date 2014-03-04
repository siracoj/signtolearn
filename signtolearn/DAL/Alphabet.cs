using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public static class Alphabet
    {
        private static String GetSQLConnectionString()
        {
            String DBServer = ConfigurationSettings.AppSettings.Get("DatabaseServer");
            String DBName = "SignToLearn";
            String DBUser = "sa";
            String DBPass = "Clasic22";
            return String.Format("user id={0};password={1};server={2};Trusted_Connection=yes;database={3};connection timeout=30; MultipleActiveResultSets=True;", DBUser, DBPass, DBServer, DBName);
        }

        public static AlphabetInfo GetLetterInfo(char Letter)
        {   //gets the determining information for a letter
            if (!Char.IsLetter(Letter))
                throw new FormatException("Inputted character is not a letter");

            SqlConnection conn = new SqlConnection(GetSQLConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT NumFingers, ClosestPoint, Percentage FROM Alphabet WHERE Letter = @letter", conn);
            cmd.Parameters.AddWithValue("@letter", Letter);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int NumFingers = Int32.Parse(reader[0].ToString());
            double ClosestPoint = double.Parse(reader[1].ToString());
            double Percentage = double.Parse(reader[2].ToString());
            conn.Close();
            return new AlphabetInfo(Letter, NumFingers, ClosestPoint, Percentage);
        }
    }

    public class AlphabetInfo
    {
        public char Letter { get; private set; }
        public int NumFingers { get; private set; }
        public double ClosestPoint { get; private set; }
        public double Percentage { get; private set; }

        public AlphabetInfo(char _Letter, int _NumFingers, double _ClosestPoint, double _Percentage)
        {
            Letter = _Letter;
            NumFingers = _NumFingers;
            ClosestPoint = _ClosestPoint;
            Percentage = _Percentage;
        }
    }
}
