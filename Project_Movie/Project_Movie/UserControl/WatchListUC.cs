﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Movie
{
    public partial class WatchListUC : UserControl
    {
        DBConnection db = new DBConnection();
        public WatchListUC()
        {
            InitializeComponent();
        }

        private void buttonAddToWL_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDeleteFromWL_Click(object sender, EventArgs e)
        {
            foreach (int i in listView1.SelectedIndices)
            {
                String deleteTitle = listView1.Items[i].Text;
                db.DeleteMovie(deleteTitle);
            }
            Update();
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
            foreach (DataRow row in db.GetEmployees().Rows)
            {
                listView1.Items.Add(row.Field<String>(0));
                listView1.Items[y].SubItems.Add(row.Field<String>(1));
                listView1.Items[y].SubItems.Add(row.Field<String>(2));
                listView1.Items[y].SubItems.Add(row.Field<String>(3));
                listView1.Items[y].SubItems.Add(row.Field<String>(4));
                listView1.Items[y].SubItems.Add(row.Field<String>(5));
                listView1.Items[y].SubItems.Add(row.Field<String>(6));
            }
        }

        private void buttonFilterAction_Click(object sender, EventArgs e)
        {

        }
    }
}
