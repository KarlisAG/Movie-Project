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
    public partial class loginForm : Form
    {
        Point lastPoint;
        DBConnection db = new DBConnection();
        Logic l = new Logic();
        public loginForm()
        {
            InitializeComponent();
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = String.Empty;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = String.Empty;
        }

        private void loginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rForm = new RegisterForm();
            rForm.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length < 1 || textBoxPassword.Text.Length < 1)
            {
                labelError.Visible = true;
                labelError.Text = "You need to enter username and/or password!";
            }
            else
            {
                if(db.Login(textBoxUsername.Text, textBoxPassword.Text))
                {
                    FormApp main = new FormApp();
                    //l.setUsername(/*textBoxUsername.Text*/"AAA");
                    //l.username = /*textBoxUsername.Text*/"AAA";
                    l.Username = textBoxUsername.Text;
                    main.Show();
                    this.Hide();
                    labelError.Visible = false;
                }
                else
                {
                    labelError.Visible = true;
                    labelError.Text = "This user does not exist! Consider creating a new one by pressing Register button!";
                }
            }
            
        }
    }
}
