/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace HandSigns
{
    class SignCheck
    {
        private IList<SignInfo> Alphabet; 
    
        public void SignCheck(String UserName)
        {
            for(int i=65; i<91; i++)
            {
                char letter = Convert.ToChar(i);
                Alphabet.Add(Sign.GetSignInfo(UserName, letter));
            }
        }
        public float compareSigns(SignInfo testSign)
        {
            float difference;


            return difference;
    }
}
*/
