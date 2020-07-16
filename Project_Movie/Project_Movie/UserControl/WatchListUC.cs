using System;
using Project_Movie.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Movie
{
    public partial class WatchListUC : UserControl
    {
        DBConnection db = new DBConnection();
        public WatchListUC()
        {
            InitializeComponent();
        }

        private void buttonAddMoreToWL_Click(object sender, EventArgs e)
        {
            AddToWL addToWL = new AddToWL();
            addToWL.ShowDialog();
            Update(sender, e);
        }

        private void buttonDeleteFromWL_Click(object sender, EventArgs e)
        {
            foreach (int i in listView1.SelectedIndices)
            {
                String deleteTitle = listView1.Items[i].Text;
                db.DeleteMovie(deleteTitle);
            }
            Update(sender, e);
        }

        private void buttonDefaultFilter_Click(object sender, EventArgs e)
        {
            labelJustParamater.Visible = !labelJustParamater.Visible;
            comboBox1.Visible = !comboBox1.Visible;
            textBoxFilter.Visible = !textBoxFilter.Visible;
            buttonFilterAction.Visible = !buttonFilterAction.Visible;

            if (labelJustParamater.Visible)
                buttonDefaultFilter.Text = "Close Filter";
            else
                buttonDefaultFilter.Text = "Open Filter";
        }

        private void Update(object sender, EventArgs e)//after filter it might bug and subitems might not show, dont know why, havent found solution; to get list back you jave to either switch UC or just logout, login nad it will be good
        {
            listView1.Items.Clear();
            int y = 0;
            foreach (DataRow row in db.GetMovies().Rows)
            {
                listView1.Items.Add(row.Field<String>(0));
                listView1.Items[y].SubItems.Add(row.Field<String>(1));
                listView1.Items[y].SubItems.Add(row.Field<String>(2));
                listView1.Items[y].SubItems.Add(row.Field<String>(3));
                listView1.Items[y].SubItems.Add(row.Field<String>(4));
                listView1.Items[y].SubItems.Add(row.Field<String>(5));
                listView1.Items[y].SubItems.Add(row.Field<String>(6));
                listView1.Items[y].SubItems.Add(row.Field<String>(7));
                y++;
            }
        }

        private void buttonFilterAction_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                richTextBoxError.Text = "You need to select a parameter in the drop down box!";
            else if (comboBox1.Text == "Title" || comboBox1.Text == "Type" || comboBox1.Text == "Year" || comboBox1.Text == "Rating" || comboBox1.Text == "Rated" || comboBox1.Text == "Genre")
            {
                listView1.Items.Clear();
                int y = 0;
                foreach(DataRow row in db.FilterMovie(comboBox1.Text, textBoxFilter.Text).Rows)
                {
                    listView1.Items.Add(row.Field<String>(0));
                    listView1.Items[y].SubItems.Add(row.Field<String>(1));
                    listView1.Items[y].SubItems.Add(row.Field<String>(2));
                    listView1.Items[y].SubItems.Add(row.Field<String>(3));
                    listView1.Items[y].SubItems.Add(row.Field<String>(4));
                    listView1.Items[y].SubItems.Add(row.Field<String>(5));
                    listView1.Items[y].SubItems.Add(row.Field<String>(6));
                    listView1.Items[y].SubItems.Add(row.Field<String>(7));
                    y++;
                }
                richTextBoxError.Clear();
            }
            else
            {
                richTextBoxError.Text = "You need to select the correct filter parameter!";
            }
        }

        private ColumnHeader SortingColumn = null;
        private void SortColumn(object sender, ColumnClickEventArgs e)//doesnt properly sort length, no idea how to change, tried with String.Remove, but the Compare() never is used..?
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = listView1.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn.Text.StartsWith("> "))
                        sort_order = SortOrder.Descending;
                    else
                        sort_order = SortOrder.Ascending;
                }
                else
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;

                // Remove the old sort indicator.
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
                SortingColumn.Text = "> " + SortingColumn.Text;
            else
                SortingColumn.Text = "< " + SortingColumn.Text;

            // Create a comparer.
            listView1.ListViewItemSorter = new ListViewComparer(e.Column, sort_order);

            // Sort.
            listView1.Sort();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBoxFilter.Clear();
            Update(sender, e);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            String defaultLink = "http://www.omdbapi.com/?apikey=9401f56d";
            String searchID = "&" + "&i=" + listView1.FocusedItem.SubItems[7].Text;
            String url = defaultLink + searchID;
            SearchUC search = new SearchUC();
            search.GetData(url);
            FormApp.Instance.buttonInfo_Click(sender, e);
        }
    }
}
