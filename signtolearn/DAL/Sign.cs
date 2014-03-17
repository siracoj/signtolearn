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
    public static class Sign
    {

        public static IList<SignInfo> GetSignInfo(String UserName, char Letter)
        {   //gets all of the calibrated and uncalibrated info to match a sign
            IList<SignInfo> signs = new List<SignInfo>();
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable rawSigns = new DataTable();

            String cmd = String.Format("SELECT AreaPercentage, NumFingers, ClosestPoint, Area from Sign where UserName = '{0}' and Sign.Letter = '{1}'", UserName, Letter);
            rawSigns = db.GetDataTable(cmd);
            foreach (DataRow r in rawSigns.Rows)
            {
                double Percentage = Double.Parse(r["AreaPercentage"].ToString());
                int NumFingers = Int32.Parse(r["NumFingers"].ToString());
                double ClosestPoint = Double.Parse(r["ClosestPoint"].ToString());
                double Area = Double.Parse(r["Area"].ToString()); 
                signs.Add(new SignInfo(Letter, UserName, Percentage, NumFingers, ClosestPoint, Area));
            }
            return signs;
        }

        public static void AddSign(SignInfo sign)
        {   //adds a users calibrated sign data to the database
            SQLiteDatabase db = new SQLiteDatabase(); 
            Dictionary<String,String> data = new Dictionary<string,string>();

            data.Add("Letter", sign.Letter.ToString());
            data.Add("UserName", sign.UserName);
            data.Add("Area", sign.Area.ToString());
            data.Add("AreaPercentage", sign.Percentage.ToString());
            data.Add("ClosestPoint", sign.ClosestPoint.ToString());
            data.Add("NumFingers", sign.NumFingers.ToString());

            db.Insert("Sign",data);
        }
    }

    public class SignInfo : AlphabetInfo
    {   //data structure to hold all information to recognize a sign
        public SignInfo(char _Letter, String _UserName, double _Percentage, int _NumFingers, double _ClosestPoint, double _Area) : base(_Letter, _NumFingers, _ClosestPoint, _Percentage)
        {
            UserName = _UserName;
            Area = _Area;
        }

        public bool CheckSign()
        {
            double error = 0;
            double threshold = .5;
            IList<SignInfo> signs = DAL.Sign.GetSignInfo(this.UserName, this.Letter);
            foreach (SignInfo sign in signs)
            {
                error += sign.Percentage / this.Percentage;
            }
            error = error / signs.Count;

            return (error < (1+threshold) && error > (1-threshold));

        }

        public String UserName { get; private set; }
        public double Area { get; private set; }
    }
}
