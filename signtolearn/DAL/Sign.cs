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
            String DBUser = "sa";
            String DBPass = "Clasic22";
            throw new NotImplementedException();
        }

        public static SignInfo GetSign(String UserName, char Letter)
        {
            SqlConnection conn = new SqlConnection(GetSQLConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT Letter, UserName, Percentage, NumFingers, ClosestPoint, Area from Sign where UserName = '{0}' and Letter = '{1}'", UserName, Letter), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Letter = Char.Parse(reader[0].ToString());
            UserName = reader[1].ToString();
            double Percentage = Double.Parse(reader[2].ToString());
            int NumFingers = Int32.Parse(reader[3].ToString());
            double ClosestPoint = Double.Parse(reader[4].ToString());
            double Area = Double.Parse(reader[5].ToString());
            conn.Close();
            return new SignInfo(Letter, UserName, Percentage, NumFingers, ClosestPoint, Area);
        }

        public static void AddSign(char Letter, String UserName, double Percentage, int NumFingers, double ClosestPoint, double Area)
        {
            SqlConnection conn = new SqlConnection(GetSQLConnectionString());
            SqlCommand cmd = new SqlCommand("INSERT into Sign (Letter, UserName, Percentage, NumFingers, ClosestPoint, Area) VALUES (@letter, @username, @percentage, @numfingers, @closestpoint, @area)", conn);
            cmd.Parameters.AddWithValue("@letter", Letter);
            cmd.Parameters.AddWithValue("@username", UserName);
            cmd.Parameters.AddWithValue("@percentage", Percentage);
            cmd.Parameters.AddWithValue("@numfingers", NumFingers);
            cmd.Parameters.AddWithValue("@closestpoint", ClosestPoint);
            cmd.Parameters.AddWithValue("@area", Area);
            cmd.ExecuteScalar();
            conn.Close();
        }

        public static void AddSign(SignInfo Input)
        {
            AddSign(Input.Letter, Input.UserName, Input.Percentage, Input.NumFingers, Input.ClosestPoint, Input.Area);
        }
    }

    public class SignInfo
    {
        public SignInfo(char _Letter, String _UserName, double _Percentage, int _NumFingers, double _ClosestPoint, double _Area)
        {
            Letter = _Letter;
            UserName = _UserName;
            Percentage = _Percentage;
            NumFingers = _NumFingers;
            ClosestPoint = _ClosestPoint;
            Area = _Area;
        }

        public char Letter
        {
            get;
            private set;
        }

        public String UserName
        {
            get;
            private set;
        }

        public double Percentage
        {
            get;
            private set;
        }

        public int NumFingers
        {
            get;
            private set;
        }

        public double ClosestPoint
        {
            get;
            private set;
        }

        public double Area
        {
            get;
            private set;
        }
    }
}
