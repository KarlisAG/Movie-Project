using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Movie.Forms;

namespace Project_Movie
{
    public partial class UserInfo : UserControl
    {
        DBConnection db = new DBConnection();
        private String OldPassword;
        public UserInfo()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(richTextBoxAge.Text, out int age))
            {
                db.EditInfo(richTextBoxUsername.Text, richTextBoxName.Text, richTextBoxSurname.Text, richTextBoxAge.Text, richTextBoxSex.Text, richTextBoxCountry.Text);
                richTextBoxError.Clear();
            }
            else
            {
                richTextBoxError.Text = "Age field must be filled with a number!";
            }
        }

        private void buttonShowMore_Click(object sender, EventArgs e)
        {
            if (labelUsername.Visible)
            {
                buttonShowMore.Text = "Show More";
            }
            else
            {
                buttonShowMore.Text = "Show Less";
            }
            buttonChangePW.Visible = !buttonChangePW.Visible;

            labelOldPass.Visible = !labelOldPass.Visible;
            textBoxOldPass.Visible = !textBoxOldPass.Visible;

            labelNewPass.Visible = !labelNewPass.Visible;
            textBoxNewPass.Visible = !textBoxNewPass.Visible;

            labelNewPass2.Visible = !labelNewPass2.Visible;
            textBoxNewPass2.Visible = !textBoxNewPass2.Visible;
        }

        private void buttonChangePW_Click(object sender, EventArgs e)
        {
            if (db.CheckOldPassword(textBoxOldPass.Text))
            {
                if (textBoxNewPass.Text == textBoxNewPass2.Text)
                {
                    ConfirmPassword confirmPassword = new ConfirmPassword(this);
                    confirmPassword.ShowDialog();
                    richTextBoxError.Clear();
                    PasswordClear();
                }
                else
                {
                    richTextBoxError.Text = "Your new password doesn't match in both fields!";
                    PasswordClear();
                }
            }
            else
            {
                richTextBoxError.Text = "Your old password doesn't match your current one!";
                PasswordClear();
            }
            
        }

        private void UserInfo_VisibleChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in db.GetUserData().Rows)
            {
                richTextBoxUsername.Text =  row.Field<String>(2);
                OldPassword = row.Field<String>(3);
                richTextBoxName.Text = row.Field<String>(4);
                richTextBoxSurname.Text = row.Field<String>(5);
                richTextBoxAge.Text = row.Field<String>(6);
                richTextBoxSex.Text = row.Field<String>(7);
                richTextBoxCountry.Text = row.Field<String>(8);
            }
        }
        private void PasswordClear()
        {
            textBoxOldPass.Clear();
            textBoxNewPass.Clear();
            textBoxNewPass2.Clear();
        }

        public void EditProfile()
        {
            db.EditPassword(textBoxNewPass.Text);
        }
    }
}
