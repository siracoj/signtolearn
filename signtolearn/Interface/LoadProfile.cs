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

            foreach (String s in DAL.User.GetUserNames())
            {
                listBoxProfiles.Items.Add(s);
            }
        }
    }
}
