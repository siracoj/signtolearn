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
    public partial class SignToLearn : Form
    {
        public SignToLearn()
        {
            InitializeComponent();
        }

        private void buttonLoadProfile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoad));
                t.Start();
                this.Hide();
                t.Join();
                this.Show();
            }
            catch (Exception)
            {
                //not sure what to do here, but we need try catches
                Environment.Exit(0);

            }
        }

        private static void OpenLoad()
        {
            Application.Run(new LoadProfile());
        }

        private void buttonCreateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenCreate));
                t.Start();
                this.Hide();
                t.Join();
                this.Show();
            }
            catch (Exception)
            {
                //not sure what to do here, but we need try catches
                Environment.Exit(0);

            }
        }

        private static void OpenCreate()
        {
            Application.Run(new CreateProfile());
        }
    }
}
