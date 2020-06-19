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

namespace Project_Movie
{
    public partial class SearchUC : UserControl
    {
        private bool basicVisible = false;
        private bool advancedVisible = false;
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
            try
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
                {
                    //String year = "&y=" + textBoxYear.Text;
                    //searchYear = and + year;
                    searchYear = and + "&y=" + textBoxYear.Text;
                }

                if (comboBoxType.Text == "Series")
                {
                    searchSeason = and + "&Season=" + textBoxSeason.Text;
                    searchEpisode = and + "&Episode=" + textBoxEpisode.Text;
                }

                if (comboBoxPlot.Text == "Full")
                {
                    searchPlot = and + "&plot=full";
                }

                if (labelTitle.Visible)
                {
                    String title = "&t=" + textBoxTitle.Text;
                    String[] arrTitle = title.Split(' ');
                    String newSearchTitle = String.Join("%20", arrTitle);
                    
                    String searchTitle = and + newSearchTitle;
                    

                    String url = defaultLink + searchTitle + searchSeason + searchEpisode + searchYear + searchPlot;
                    linkLabel1.Text = url;
                    
                    GetData(url);
                }
                else if (labelImdbID.Visible)
                {
                    String searchID = "&i=" + textBoxTitle.Text;
                    String url = defaultLink + searchID + searchSeason + searchEpisode + searchYear + searchPlot;
                    GetData(url);
                }
                //labelSearchStatus.Text = "Search succesful! Check Movie Info section.";
                
                
            }
            catch (Exception ex)
            {
                labelSearchStatus.Text = "Fail! " + ex.Message;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTitle.Clear();
            comboBoxPlot.Text = "";

            ClearAdvancedTextBoxes();
        }

        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            AdvancedVisibilityChange();
            ClearAdvancedTextBoxes();
        }

        private void SearchUC_Load(object sender, EventArgs e)
        {

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
            {
                buttonAdvanced.Visible = true;
            }
            else if (type == "ID")
            {
                buttonAdvanced.Visible = false;
            }
        }

        private void AdvancedVisibilityChange()
        {
            labelType.Visible = !advancedVisible;
            comboBoxType.Visible = !advancedVisible;

            labelYear.Visible = !advancedVisible;
            textBoxYear.Visible = !advancedVisible;

            advancedVisible = !advancedVisible;

            if (advancedVisible == false)
            {
                buttonAdvanced.Text = "Show Advanced Search";
            }
            else
            {
                buttonAdvanced.Text = "Close Advanced Search";
            }

            labelSeason.Visible = false;
            textBoxSeason.Visible = false;

            labelEpisode.Visible = false;
            textBoxEpisode.Visible = false;
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

        private void GetData(String url)
        {

        }

        private void ClearAdvancedTextBoxes()
        {
            textBoxYear.Clear();
            textBoxSeason.Clear();
            textBoxEpisode.Clear();
            comboBoxType.Text = "";
        }
    }
}
