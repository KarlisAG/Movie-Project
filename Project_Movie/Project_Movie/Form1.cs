using System;
using System.Windows.Forms;

namespace Project_Movie
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
