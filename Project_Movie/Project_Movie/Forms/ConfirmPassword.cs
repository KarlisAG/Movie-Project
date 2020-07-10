using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Movie
{
    public partial class ConfirmPassword : Form
    {
        UserInfo userInfo;
        public ConfirmPassword(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            userInfo.EditProfile();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
