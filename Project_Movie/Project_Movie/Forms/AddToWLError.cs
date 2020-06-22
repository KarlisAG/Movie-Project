using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Movie.Forms;
using System.Windows.Forms;

namespace Project_Movie.Forms
{
    public partial class AddToWLError : Form
    {
        public AddToWLError()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            AddToWL addToWL = new AddToWL();
            addToWL.AddAnyway();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
