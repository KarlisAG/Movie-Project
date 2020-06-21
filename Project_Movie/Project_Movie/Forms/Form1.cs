using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Movie
{
    public partial class FormApp : Form
    {
        Point lastPoint;
        public FormApp()
        {
            InitializeComponent();
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
        }

        private void buttonWatchList_Click(object sender, EventArgs e)
        {
            buttonSlider.Visible = true;
            buttonSlider.Location = buttonWatchList.Location;
            watchListUC1.Visible = true;
            searchUC1.Visible = false;
            infoUC1.Visible = false;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            buttonSlider.Visible = true;
            buttonSlider.Location = buttonInfo.Location;
            infoUC1.Visible = true;
            searchUC1.Visible = false;
            watchListUC1.Visible = false;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            buttonSlider.Visible = true;
            buttonSlider.Location = buttonUser.Location;
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
    }
}
