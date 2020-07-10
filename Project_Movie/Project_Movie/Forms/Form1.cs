using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using Project_Movie.Forms;

namespace Project_Movie
{
    public partial class FormApp : Form
    {
        Point lastPoint;
        DBConnection db;
        loginForm login;
        public String ussername;

        static FormApp _obj;

        public static FormApp Instance
        {
            get
            {
                return _obj;
            }
        }
        public FormApp(loginForm login)
        {
            InitializeComponent();
            this.login = login;
            db = new DBConnection(login);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            buttonSlider.Visible = true;
            buttonSlider.Location = buttonSearch.Location;
            searchUC1.Visible = true;
            infoUC1.Visible = false;
            watchListUC1.Visible = false;
            userInfo.Visible = false;
        }

        private void buttonWatchList_Click(object sender, EventArgs e)
        {
            buttonSlider.Visible = true;
            buttonSlider.Location = buttonWatchList.Location;
            watchListUC1.Visible = true;
            searchUC1.Visible = false;
            infoUC1.Visible = false;
            userInfo.Visible = false;
        }

        public void buttonInfo_Click(object sender, EventArgs e)
        {
            buttonSlider.Visible = true;
            buttonSlider.Location = buttonMovieInfo.Location;
            infoUC1.Visible = true;
            searchUC1.Visible = false;
            watchListUC1.Visible = false;
            userInfo.Visible = false;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            buttonSlider.Visible = true;
            buttonSlider.Location = buttonUserInfo.Location;
            userInfo.Visible = true;
            infoUC1.Visible = false;
            searchUC1.Visible = false;
            watchListUC1.Visible = false;
        }
        private void FormApp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FormApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void FormApp_Activated(object sender, EventArgs e)
        {
            db.setUserID();
        }

        public void ToInfo(object sender, EventArgs e)
        {
            buttonInfo_Click(sender, e);
        }

        private void FormApp_Load(object sender, EventArgs e)
        {
            _obj = this;

        }
    }
}
