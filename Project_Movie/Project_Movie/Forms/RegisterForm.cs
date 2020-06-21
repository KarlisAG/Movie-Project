using System;
using Project_Movie.Forms;
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
        Logic l = new Logic();
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
                if (textBoxAge.Text.Length >= 1)
                {
                    bool isNumber = Int32.TryParse(textBoxAge.Text, out int result);
                    if (isNumber)
                    {
                        Register();
                    }
                    else
                    {
                        labelError.Visible = true;
                        labelError.Text = "You need to enter a number in Age!";
                    }
                }
                else
                {
                    Register();
                }
            }
        }

        private void Register()
        {
            if (textBoxPassword.Text == textBoxPasswordConfirm.Text)
            {
                if (db.CheckUsernameDuplicate(textBoxUsername.Text))
                {
                    labelError.Visible = true;
                    labelError.Text = "That username already exists! Please choose a different one.";
                }
                else
                {
                    db.RegisterUser(textBoxUsername.Text, textBoxPassword.Text, textBoxName.Text, textBoxSurname.Text, textBoxAge.Text, comboBoxSex.Text, textBoxCountry.Text);
                    this.Hide();
                    l.setUsername(textBoxUsername.Text);
                    loginForm lForm = new loginForm();
                    lForm.Hide();
                    FormApp fApp = new FormApp();
                    fApp.Show();
                    labelError.Visible = false;
                }
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
