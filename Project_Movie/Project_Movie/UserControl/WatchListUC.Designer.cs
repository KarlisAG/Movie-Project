namespace Project_Movie
{
    partial class WatchListUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImdbID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddMoreToWL = new System.Windows.Forms.Button();
            this.buttonDeleteFromWL = new System.Windows.Forms.Button();
            this.buttonDefaultFilter = new System.Windows.Forms.Button();
            this.labelJustParamater = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonFilterAction = new System.Windows.Forms.Button();
            this.richTextBoxError = new System.Windows.Forms.RichTextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Type,
            this.Year,
            this.Length,
            this.Rating,
            this.Rated,
            this.Genre,
            this.ImdbID});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(837, 383);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortColumn);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 274;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 85;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 71;
            // 
            // Length
            // 
            this.Length.Text = "Length";
            this.Length.Width = 63;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            this.Rating.Width = 67;
            // 
            // Rated
            // 
            this.Rated.Text = "Rated";
            this.Rated.Width = 57;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 126;
            // 
            // ImdbID
            // 
            this.ImdbID.Text = "Imdb ID";
            this.ImdbID.Width = 86;
            // 
            // buttonAddMoreToWL
            // 
            this.buttonAddMoreToWL.Location = new System.Drawing.Point(3, 419);
            this.buttonAddMoreToWL.Name = "buttonAddMoreToWL";
            this.buttonAddMoreToWL.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMoreToWL.TabIndex = 1;
            this.buttonAddMoreToWL.Text = "Add More To Watch List";
            this.buttonAddMoreToWL.UseVisualStyleBackColor = true;
            this.buttonAddMoreToWL.Click += new System.EventHandler(this.buttonAddMoreToWL_Click);
            // 
            // buttonDeleteFromWL
            // 
            this.buttonDeleteFromWL.Location = new System.Drawing.Point(165, 419);
            this.buttonDeleteFromWL.Name = "buttonDeleteFromWL";
            this.buttonDeleteFromWL.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteFromWL.TabIndex = 2;
            this.buttonDeleteFromWL.Text = "Delete";
            this.buttonDeleteFromWL.UseVisualStyleBackColor = true;
            this.buttonDeleteFromWL.Click += new System.EventHandler(this.buttonDeleteFromWL_Click);
            // 
            // buttonDefaultFilter
            // 
            this.buttonDefaultFilter.Location = new System.Drawing.Point(246, 419);
            this.buttonDefaultFilter.Name = "buttonDefaultFilter";
            this.buttonDefaultFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonDefaultFilter.TabIndex = 3;
            this.buttonDefaultFilter.Text = "Open Filter";
            this.buttonDefaultFilter.UseVisualStyleBackColor = true;
            this.buttonDefaultFilter.Click += new System.EventHandler(this.buttonDefaultFilter_Click);
            // 
            // labelJustParamater
            // 
            this.labelJustParamater.AutoSize = true;
            this.labelJustParamater.Location = new System.Drawing.Point(327, 419);
            this.labelJustParamater.Name = "labelJustParamater";
            this.labelJustParamater.Size = new System.Drawing.Size(58, 13);
            this.labelJustParamater.TabIndex = 4;
            this.labelJustParamater.Text = "Paramater:";
            this.labelJustParamater.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Title",
            "Type",
            "Year",
            "Rating",
            "Rated",
            "Genre"});
            this.comboBox1.Location = new System.Drawing.Point(390, 419);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Visible = false;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(471, 419);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(75, 20);
            this.textBoxFilter.TabIndex = 6;
            this.textBoxFilter.Visible = false;
            // 
            // buttonFilterAction
            // 
            this.buttonFilterAction.Location = new System.Drawing.Point(552, 419);
            this.buttonFilterAction.Name = "buttonFilterAction";
            this.buttonFilterAction.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterAction.TabIndex = 7;
            this.buttonFilterAction.Text = "Filter";
            this.buttonFilterAction.UseVisualStyleBackColor = true;
            this.buttonFilterAction.Visible = false;
            this.buttonFilterAction.Click += new System.EventHandler(this.buttonFilterAction_Click);
            // 
            // richTextBoxError
            // 
            this.richTextBoxError.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxError.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxError.Name = "richTextBoxError";
            this.richTextBoxError.Size = new System.Drawing.Size(756, 21);
            this.richTextBoxError.TabIndex = 8;
            this.richTextBoxError.Text = "";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(84, 419);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh List";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // WatchListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.richTextBoxError);
            this.Controls.Add(this.buttonFilterAction);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelJustParamater);
            this.Controls.Add(this.buttonDefaultFilter);
            this.Controls.Add(this.buttonDeleteFromWL);
            this.Controls.Add(this.buttonAddMoreToWL);
            this.Controls.Add(this.listView1);
            this.Name = "WatchListUC";
            this.Size = new System.Drawing.Size(843, 456);
            this.VisibleChanged += new System.EventHandler(this.Update);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAddMoreToWL;
        private System.Windows.Forms.Button buttonDeleteFromWL;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ColumnHeader Rated;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.Button buttonDefaultFilter;
        private System.Windows.Forms.Label labelJustParamater;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonFilterAction;
        private System.Windows.Forms.RichTextBox richTextBoxError;
        private System.Windows.Forms.ColumnHeader ImdbID;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
