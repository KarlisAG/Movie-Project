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
    public partial class DeleteProfile : Form
    {
        UserInfo userInfo;
        public DeleteProfile(UserInfo userInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            this.AcceptButton = buttonYes;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            userInfo.DeleteProfile();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
