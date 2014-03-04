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
            LoadProfile LP = new LoadProfile();
            //this.Hide();
            LP.Show();
        }
    }
}
