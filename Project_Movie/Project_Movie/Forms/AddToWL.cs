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
            this.AcceptButton = buttonAdd;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "-" || textBoxType.Text == "-" || textBoxYear.Text == "-" || textBoxLength.Text == "-" || textBoxRating.Text == "-" || textBoxRated.Text == "-" || textBoxGenre.Text == "-" || textBoxImdbID.Text == "-")
            {
                AddToWLError aError = new AddToWLError(this);
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
            db.AddMovieAnyway(textBoxTitle.Text, textBoxType.Text, textBoxYear.Text, textBoxLength.Text, textBoxRating.Text, textBoxRated.Text, textBoxGenre.Text, textBoxImdbID.Text);
        }
    }
}
