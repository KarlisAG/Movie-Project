using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Movie.Forms;

namespace Project_Movie.Forms
{
    public partial class AddToWL : Form
    {
        DBConnection db = new DBConnection();
        public AddToWL()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text.Length < 1 || textBoxType.Text.Length < 1 || textBoxYear.Text.Length < 1 || textBoxLength.Text.Length < 1 || textBoxRating.Text.Length < 1|| textBoxRated.Text.Length < 1 || textBoxGenre.Text.Length < 1 || textBoxImdbID.Text.Length < 1)
            {
                AddToWLError aError = new AddToWLError();
                aError.ShowDialog();
                this.Hide();
                
            }
            else
            {
                AddAnyway();
                this.Hide();
            }
        }

        public void AddAnyway()
        {

            db.AddMovie(textBoxTitle.Text, textBoxType.Text, textBoxYear.Text, textBoxLength.Text, textBoxRating.Text, textBoxRated.Text, textBoxGenre.Text, textBoxImdbID.Text);
        }
    }
}
