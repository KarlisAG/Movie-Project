using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Movie.Forms
{
    public partial class RegisterForm : Form
    {
        DBConnection db = new DBConnection();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length < 1 || textBoxPassword.Text.Length < 1 || textBoxPasswordConfirm.Text.Length < 1)
            {
                labelError.Visible = true;
                labelError.Text = "You need to fill the required fields!";
            }
            else
            {
                if (textBoxPassword.Text == textBoxPasswordConfirm.Text)
                {
                    db.RegisterUser();//visu ielikt + parbaudit vai vecums ir cipari
                }
                else
                {
                    labelError.Visible = true;
                    labelError.Text = "Passwords must match!";
                    textBoxPassword.Clear();
                    textBoxPasswordConfirm.Clear();
                }
            }
        }
    }
}
