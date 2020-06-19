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
            buttonSlider.Location = buttonSearch.Location;
            searchUC1.Visible = true;
        }

        private void buttonWatchList_Click(object sender, EventArgs e)
        {
            buttonSlider.Location = buttonWatchList.Location;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            buttonSlider.Location = buttonInfo.Location;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            buttonSlider.Location = buttonUser.Location;
        }
    }
}
