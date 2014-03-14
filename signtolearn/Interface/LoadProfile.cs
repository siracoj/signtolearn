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
    public partial class LoadProfile : Form
    {
        public LoadProfile()
        {
            InitializeComponent();
            try
            {
                foreach (String s in DAL.User.GetUserNames())
                {
                    listBoxProfiles.Items.Add(s);
                }
                if (listBoxProfiles.Items.Count > 0)
                {
                    listBoxProfiles.SetSelected(0, true);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(String.Format("Could not connect to database\n {0}", x.Message));
            }
        }

        private void cancelLoadProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmLoadProfile_Click(object sender, EventArgs e)
        {
            String UserName = listBoxProfiles.SelectedItem.ToString();
            System.Threading.Thread t = new System.Threading.Thread(() => OpenProfile(UserName));
            t.Start();
            this.Hide();
            t.Join();
            this.Close();
        }

        private static void OpenProfile(String UserName)
        {
            Application.Run(new UserHomePage(UserName));
        }
    }
}
