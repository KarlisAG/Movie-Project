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
                richTextBoxInfo.Text = "Your profile info has been edited!";
            }
            else
            {
                richTextBoxError.Text = "Age field must be filled with a number!";
            }
        }

        private void buttonShowMore_Click(object sender, EventArgs e)
        {
            if (labelOldPass.Visible)
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
                    if (textBoxNewPass.Text == textBoxOldPass.Text)
                    {
                        richTextBoxError.Text = "Your new password cannot be the same as the new one!";
                        richTextBoxInfo.Clear();
                        PasswordClear();
                    }
                    else
                    {
                        ConfirmPassword confirmPassword = new ConfirmPassword(this);
                        confirmPassword.ShowDialog();
                        richTextBoxError.Clear();
                        PasswordClear();
                        richTextBoxInfo.Text = "Your password has been changed!";
                    }
                }
                else
                {
                    richTextBoxError.Text = "Your new password doesn't match in both fields!";
                    PasswordClear();
                    richTextBoxInfo.Clear();
                }
            }
            else
            {
                richTextBoxError.Text = "Your old password doesn't match your current one!";
                PasswordClear();
                richTextBoxInfo.Clear();
            }
            
        }

        private void UserInfo_VisibleChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in db.GetUserData().Rows)
            {
                richTextBoxUsername.Text =  row.Field<String>(1);
                OldPassword = row.Field<String>(2);
                richTextBoxName.Text = row.Field<String>(3);
                richTextBoxSurname.Text = row.Field<String>(4);
                richTextBoxAge.Text = row.Field<String>(5);
                richTextBoxSex.Text = row.Field<String>(6);
                richTextBoxCountry.Text = row.Field<String>(7);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteProfile delete = new DeleteProfile(this);
            delete.ShowDialog();
        }

        public void DeleteProfile()
        {
            db.DeleteProfile();
            this.Hide();
            loginForm lForm = new loginForm();
            lForm.Show();
            FormApp formApp = (FormApp)this.FindForm();
            formApp.Close();
            formApp.Dispose();
            //((FormApp)this.TopLevelControl).Close();
        }
    }
}
