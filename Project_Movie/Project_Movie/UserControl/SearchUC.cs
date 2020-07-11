using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Project_Movie
{
    public partial class SearchUC : UserControl
    {
        private bool basicVisible = false;
        private bool advancedVisible = false;
        DBConnection db = new DBConnection();
        MovieData md;
        public SearchUC()
        {
            InitializeComponent();
        }

        private void buttonSearchByTitle_Click(object sender, EventArgs e)
        {
            labelTitle.Visible = true;
            labelImdbID.Visible = false;
            BasicVisibilityChange("Title");
        }

        private void buttonSearchByID_Click(object sender, EventArgs e)
        {
            labelImdbID.Visible = true;
            labelTitle.Visible = false;
            BasicVisibilityChange("ID");
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String defaultLink = "http://www.omdbapi.com/?apikey=9401f56d";
            String searchYear = String.Empty;
            String searchSeason = String.Empty;
            String searchEpisode = String.Empty;
            String searchPlot = String.Empty;
            String searchType = String.Empty;
            char and = '&';
            searchYear = textBoxYear.Text;

            if (searchYear != String.Empty)
                searchYear = and + "&y=" + textBoxYear.Text;

            if (comboBoxType.Text == "Series")
            {
                searchSeason = and + "&Season=" + textBoxSeason.Text;
                searchEpisode = and + "&Episode=" + textBoxEpisode.Text;
            }

            if (comboBoxPlot.Text == "Full")
                searchPlot = and + "&plot=full";

            if (labelTitle.Visible == true)
            {
                String title = "&t=" + textBoxTitle.Text;
                String[] arrTitle = title.Split(' ');
                String newSearchTitle = String.Join("%20", arrTitle);
                String searchTitle = and + newSearchTitle;
                String url = defaultLink + searchTitle + searchSeason + searchEpisode + searchYear + searchPlot;
                GetData(url);
            }
            else if (labelImdbID.Visible == true)
            {
                String searchID = and + "&i=" + textBoxTitle.Text;
                String url = defaultLink + searchID + searchPlot;
                GetData(url);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTitle.Clear();
            comboBoxPlot.Text = "";
            ClearAdvancedTextBoxes();
            labelErrorMessage.Visible = false;
            labelSearchStatus.Visible = false;
        }

        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            AdvancedVisibilityChange();
            ClearAdvancedTextBoxes();
        }


        private void BasicVisibilityChange(String type)
        {
            if (basicVisible == false)
            {
                labelTitle.Visible = true;
                textBoxTitle.Visible = true;
                labelPlot.Visible = true;
                comboBoxPlot.Visible = true;
                buttonSearch.Visible = true;
                buttonClear.Visible = true;
                basicVisible = true;
            }
            if (type == "Title")
                buttonAdvanced.Visible = true;
            else if (type == "ID")
                buttonAdvanced.Visible = false;
        }

        private void AdvancedVisibilityChange()
        {
            labelType.Visible = !advancedVisible;
            comboBoxType.Visible = !advancedVisible;

            labelYear.Visible = !advancedVisible;
            textBoxYear.Visible = !advancedVisible;

            labelOptional.Visible = !advancedVisible;

            advancedVisible = !advancedVisible;

            if (advancedVisible == false)
                buttonAdvanced.Text = "Show Advanced Search";
            else
                buttonAdvanced.Text = "Close Advanced Search";

            labelSeason.Visible = false;
            textBoxSeason.Visible = false;

            labelEpisode.Visible = false;
            textBoxEpisode.Visible = false;
        }
        private void CheckNumber(object sender, EventArgs e)
        {
            bool yearParse = int.TryParse(textBoxYear.Text, out int result1);
            bool seasonParse = int.TryParse(textBoxSeason.Text, out int result2);
            bool episodeParse = int.TryParse(textBoxEpisode.Text, out int result3);

            if (yearParse != true && textBoxYear.Text.Length >= 1)
            {
                labelNumberError.Visible = true;
                labelNumberError.Text = "You need to enter a number in the Year textbox!";
            }
            else if (seasonParse != true && textBoxSeason.Text.Length >= 1)
            {
                labelNumberError.Visible = true;
                labelNumberError.Text = "You need to enter a number in the Season textbox!";
            }
            else if (episodeParse != true && textBoxEpisode.Text.Length >= 1)
            {
                labelNumberError.Visible = true;
                labelNumberError.Text = "You need to enter a number in the Episode textbox!";
            }
            else
                labelNumberError.Visible = false;
        }
        private void TypeChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "Series")
            {
                labelSeason.Visible = true;
                textBoxSeason.Visible = true;

                labelEpisode.Visible = true;
                textBoxEpisode.Visible = true;
            }
            else
            {
                labelSeason.Visible = false;
                textBoxSeason.Visible = false;

                labelEpisode.Visible = false;
                textBoxEpisode.Visible = false;
            }
        }

        public void GetData(String url)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(url);
            md = JsonConvert.DeserializeObject<MovieData>(response);
            if (md.Response == "True")
            {
                labelErrorMessage.Visible = false;
                labelSearchStatus.Visible = true;
                labelSearchStatus.Text = "Search successful! You can view its information in Movie Info tab!";
                buttonAddToWL.Visible = true;

                StreamWriter sw = new StreamWriter("CurrentMovie.json");
                sw.Write(response);
                sw.Close();
            }
            else if (md.Response == "False")
            {
                labelErrorMessage.Visible = true;
                labelSearchStatus.Visible = true;

                labelSearchStatus.Text = "Search unsuccessful!";
                labelErrorMessage.Text = md.error;
            }
        }

        private void ClearAdvancedTextBoxes()
        {
            textBoxYear.Clear();
            textBoxSeason.Clear();
            textBoxEpisode.Clear();
            comboBoxType.Text = String.Empty;
        }

        private void buttonAddToWL_Click(object sender, EventArgs e)
        {
            char[] seperators = { 'ā', '€', '“' };
            string[] temp = md.Year.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            String movieYear = String.Join("-", temp);
            if (db.AddMovie(md.Title, md.Type, movieYear, md.Runtime, md.Metascore, md.Rated, md.Genre, md.ImdbID))
            {
                labelErrorMessage.Visible = true;
                labelErrorMessage.Text = "This movie/series is already saved in your watch list!";
            }
            else
            {
                labelErrorMessage.Text = String.Empty;
                labelErrorMessage.Visible = false;
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            labelSearchStatus.Visible = false;
            labelErrorMessage.Visible = false;
        }
    }
}
