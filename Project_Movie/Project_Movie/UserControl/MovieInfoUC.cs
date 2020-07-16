using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Project_Movie
{
    public partial class InfoUC : UserControl
    {
        DBConnection db = new DBConnection();
        public InfoUC()
        {
            InitializeComponent();
        }

        private void linkLabelImdb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabelImdb.Text);
        }

        private void buttonExtraIMDBInfo_Click(object sender, EventArgs e)
        {
            labelJustIMDB_ID.Visible = !labelJustIMDB_ID.Visible;
            richTextBoxInfoImdbID.Visible = !richTextBoxInfoImdbID.Visible;

            labelJustImdbRating.Visible = !labelJustImdbRating.Visible;
            richTextBoxInfoImdbRating.Visible = !richTextBoxInfoImdbRating.Visible;

            labelJustImdbVotes.Visible = !labelJustImdbVotes.Visible;
            richTextBoxInfoImdbVotes.Visible = !richTextBoxInfoImdbVotes.Visible;

            if (labelJustIMDB_ID.Visible == true)
                buttonExtraIMDBInfo.Text = "Less Imdb Info";
            else
                buttonExtraIMDBInfo.Text = "More Imdb Info";
        }

        private void buttonExtraRatings_Click(object sender, EventArgs e)
        {
            listViewRatings.Visible = !listViewRatings.Visible;
            if (listViewRatings.Visible == true)
                buttonExtraRatings.Text = "Less Ratings";
            else
                buttonExtraRatings.Text = "More Ratings";
            
        }

        private void buttonSaveToWatchlist_Click(object sender, EventArgs e)
        {
            if(db.AddMovie(labelInfoTitle.Text, richTextBoxInfoType.Text, richTextBoxInfoYear.Text, richTextBoxInfoRuntime.Text, richTextBoxInfoMetascore.Text, richTextBoxInfoRated.Text, richTextBoxInfoGenres.Text, richTextBoxInfoImdbID.Text))
            {
                labelError.Visible = true;
                labelError.Text = "This movie/series is already saved in your watch list!";
            }
            else
                labelError.Visible = false;
        }

        private void Update(object sender, EventArgs e)
        {
            labelError.Visible = false;
            try
            {
                MovieData md = JsonConvert.DeserializeObject<MovieData>(File.ReadAllText("CurrentMovie.json"));
                labelInfoTitle.Text = md.Title;
                
                char[] seperators = { 'ā', '€', '“' };
                string[] temp = md.Year.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                richTextBoxInfoYear.Text = String.Join("-", temp);
                richTextBoxInfoCountry.Text = md.Country;
                richTextBoxInfoGenres.Text = md.Genre;
                richTextBoxInfoRated.Text = md.Rated;
                richTextBoxInfoActors.Text = md.Actors;
                richTextBoxInfoRuntime.Text = md.Runtime;
                richTextBoxInfoType.Text = md.Type;
                richTextBoxInfoWriter.Text = md.Writer;
                richTextBoxInfoPlot.Text = md.Plot;
                richTextBoxInfoProduction.Text = md.Production;
                richTextBoxInfoMetascore.Text = md.Metascore;
                linkLabelImdb.Text = "https://www.imdb.com/title/" + md.ImdbID;

                richTextBoxInfoImdbID.Text = md.ImdbID;
                richTextBoxInfoImdbRating.Text = md.ImdbRating;
                richTextBoxInfoImdbVotes.Text = md.ImdbVotes;

                pictureBox1.Load(md.Poster);

                listViewRatings.Items.Clear();
                List<Ratings> rt = new List<Ratings>();
                int y = 0;
                foreach (Ratings r in md.Ratings)
                {
                    listViewRatings.Items.Add(r.Source);
                    listViewRatings.Items[y].SubItems.Add(r.Value);
                    y++;
                }
            }
            catch { }
        }
    }
}
