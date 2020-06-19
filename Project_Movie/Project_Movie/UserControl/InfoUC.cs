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
            labelInfoImdbID.Visible = !labelInfoImdbID.Visible;

            labelJustImdbRating.Visible = !labelJustImdbRating.Visible;
            labelInfoImdbRating.Visible = !labelInfoImdbRating.Visible;

            labelJustImdbVotes.Visible = !labelJustImdbVotes.Visible;
            labelInfoImdbVotes.Visible = !labelInfoImdbVotes.Visible;

            if (labelJustIMDB_ID.Visible == true)
            {
                buttonExtraIMDBInfo.Text = "Less Imdb Info";
            }
            else
            {
                buttonExtraIMDBInfo.Text = "More Imdb Info";
            }
            
        }

        private void buttonExtraRatings_Click(object sender, EventArgs e)
        {
            listViewRatings.Visible = !listViewRatings.Visible;
            if (listViewRatings.Visible == true)
            {
                buttonExtraRatings.Text = "Less Ratings";
            }
            else
            {
                buttonExtraRatings.Text = "More Ratings";
            }
            
        }

        private void buttonSaveToWatchlist_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MovieData md = JsonConvert.DeserializeObject<MovieData>(File.ReadAllText("CurrentMovie.json"));
                labelInfoTitle.Text = md.Title;
                labelInfoYear.Text = md.Year;
                labelInfoCountry.Text = md.Country;
                labelInfoGenre.Text = md.Genre;
                labelInfoRated.Text = md.Rated;
                labelInforActors.Text = md.Actors;
                labelInfoRuntime.Text = md.Runtime;
                labelInfoType.Text = md.Type;
                labelInfoWriter.Text = md.Writer;
                labelInfoPlot.Text = md.Plot;
                labelInfoProduction.Text = md.Production;
                labelInfoMetascore.Text = md.Metascore;
                linkLabelImdb.Text = "https://www.imdb.com/title/" + md.ImdbID;

                labelInfoImdbID.Text = md.ImdbID;
                labelInfoImdbRating.Text = md.ImdbRating;
                labelInfoImdbVotes.Text = md.ImdbVotes;

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
            catch (Exception ex)
            {
                labelInfoRuntime.Text = ex.Message;
            }
        }
    }
}
