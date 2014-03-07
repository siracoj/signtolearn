using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class UserHomePage : Form
    {
        public UserHomePage(String UserName)
        {
            InitializeComponent();
            try
            {
                LabelUsername.Text = DAL.User.GetName(UserName);
                int Percent = (int)((double)(DAL.User.GetProgress(UserName) - 65) / 25 * 100);
                labelTrainingProgressPercentage.Text = String.Format("{0}% Complete", Percent);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to database");
                this.Close();
            }
        }
    }
}
