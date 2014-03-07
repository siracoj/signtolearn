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
    public partial class CreateProfile : Form
    {
        public CreateProfile()
        {
            InitializeComponent();
        }

        private void buttonCancelCreateUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmCreateUser_Click(object sender, EventArgs e)
        {
            if (DAL.User.AddProfile(textBoxUsername.Text, textBoxFirstName.Text, textBoxLastName.Text))
                this.Close();
            else if (textBoxFirstName.Text == null)
                textBoxUsername.Text = "Need to enter a username";
            else if (textBoxLastName.Text == null)
                textBoxLastName.Text = "Need to enter a last name";
            else if (textBoxFirstName.Text == null)
                textBoxFirstName.Text = "Need to enter a first name";
            else
                textBoxUsername.Text = "UserName Taken";
        }
    }
}
