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

                searchYear = textBoxYear.Text;
                if (searchYear != String.Empty)
                {
                    searchYear = "&y=" + textBoxYear.Text;
                }

                if (comboBoxType.Text == "Series")
                {
                    searchSeason = "&Season=" + textBoxSeason.Text;
                    searchEpisode = "&Episode=" + textBoxEpisode.Text;
                }

                if (comboBoxPlot.Text == "Full")
                {
                    searchPlot = "&" + "plot=full";
                }

                if (labelTitle.Visible)
                {
                    String searchTitle = "&t=" + textBoxTitle.Text;
                    String url = defaultLink + searchTitle + searchSeason + searchEpisode + searchYear + searchPlot;
                    linkLabel1.Text = url;
                    labelSearchStatus.Visible = true;
                    labelSearchStatus.Text = url;
                }
                else if (labelImdbID.Visible)
                {
                    String searchID = "&i=" + textBoxTitle.Text;
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
            textBoxYear.Clear();
            textBoxSeason.Clear();
            textBoxEpisode.Clear();
            comboBoxPlot.Text = "";
            comboBoxType.Text = "";
        }

        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            AdvancedVisibilityChange();
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

            labelSeason.Visible = !advancedVisible;
            textBoxSeason.Visible = !advancedVisible;

            labelEpisode.Visible = !advancedVisible;
            textBoxEpisode.Visible = !advancedVisible;

            advancedVisible = !advancedVisible;

            if (advancedVisible == false)
            {
                buttonAdvanced.Text = "Show Advanced Search";
            }
            else
            {
                buttonAdvanced.Text = "Close Advanced Search";
            }
        }

        private void TypeChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "Series")
            {

            }
        }
    }
}
