﻿using System;
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
        bool asc = true;
        public WatchListUC()
        {
            InitializeComponent();
        }

        private void buttonAddMoreToWL_Click(object sender, EventArgs e)
        {
            var formPupUp = new Form();
            formPupUp.ShowDialog();
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
            {
                buttonDefaultFilter.Text = "Close Filter";
            }
            else
            {
                buttonDefaultFilter.Text = "Open Filter";
            }
        }

        private void Update(object sender, EventArgs e)
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
            {
                richTextBoxError.Text = "You need to select a parameter in the drop down box!";
            }
            else 
            { 
                String filterParameter = comboBox1.Text;
                String filter = textBoxFilter.Text;
                listView1.Items.Clear();
                int y = 0;
                foreach(DataRow row in db.FilterMovie(filterParameter, filter).Rows)
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
        }

        private void SortColumn(object sender, ColumnClickEventArgs e)
        {
            
            if (asc)
            {
                listView1.Sorting = SortOrder.Descending;//sataisit sorting norm
                asc = !asc;
            }
            else
            {
                listView1.Sorting = SortOrder.Ascending;
                asc = !asc;
            }
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Update(sender, e);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //aiziet uz movie infu
        }
    }
}
