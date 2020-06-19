namespace Project_Movie
{
    partial class WatchList
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
            this.buttonAddToWL = new System.Windows.Forms.Button();
            this.buttonDeleteFromWL = new System.Windows.Forms.Button();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDefaultFilter = new System.Windows.Forms.Button();
            this.labelJustParamater = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxFiler = new System.Windows.Forms.TextBox();
            this.buttonFilerAction = new System.Windows.Forms.Button();
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
            this.Genre});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonAddToWL
            // 
            this.buttonAddToWL.Location = new System.Drawing.Point(765, 15);
            this.buttonAddToWL.Name = "buttonAddToWL";
            this.buttonAddToWL.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToWL.TabIndex = 1;
            this.buttonAddToWL.Text = "Add More To Watch List";
            this.buttonAddToWL.UseVisualStyleBackColor = true;
            this.buttonAddToWL.Click += new System.EventHandler(this.buttonAddToWL_Click);
            // 
            // buttonDeleteFromWL
            // 
            this.buttonDeleteFromWL.Location = new System.Drawing.Point(765, 44);
            this.buttonDeleteFromWL.Name = "buttonDeleteFromWL";
            this.buttonDeleteFromWL.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteFromWL.TabIndex = 2;
            this.buttonDeleteFromWL.Text = "Delete";
            this.buttonDeleteFromWL.UseVisualStyleBackColor = true;
            this.buttonDeleteFromWL.Click += new System.EventHandler(this.buttonDeleteFromWL_Click);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 289;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 70;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 71;
            // 
            // Length
            // 
            this.Length.Text = "Length";
            this.Length.Width = 72;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            this.Rating.Width = 83;
            // 
            // Rated
            // 
            this.Rated.Text = "Rated";
            this.Rated.Width = 59;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 106;
            // 
            // buttonDefaultFilter
            // 
            this.buttonDefaultFilter.Location = new System.Drawing.Point(765, 73);
            this.buttonDefaultFilter.Name = "buttonDefaultFilter";
            this.buttonDefaultFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonDefaultFilter.TabIndex = 3;
            this.buttonDefaultFilter.Text = "Open Filter";
            this.buttonDefaultFilter.UseVisualStyleBackColor = true;
            // 
            // labelJustParamater
            // 
            this.labelJustParamater.AutoSize = true;
            this.labelJustParamater.Location = new System.Drawing.Point(765, 99);
            this.labelJustParamater.Name = "labelJustParamater";
            this.labelJustParamater.Size = new System.Drawing.Size(58, 13);
            this.labelJustParamater.TabIndex = 4;
            this.labelJustParamater.Text = "Paramater:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Type",
            "Year",
            "Rated",
            "Rating",
            "Genre"});
            this.comboBox1.Location = new System.Drawing.Point(765, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // textBoxFiler
            // 
            this.textBoxFiler.Location = new System.Drawing.Point(765, 153);
            this.textBoxFiler.Name = "textBoxFiler";
            this.textBoxFiler.Size = new System.Drawing.Size(75, 20);
            this.textBoxFiler.TabIndex = 6;
            // 
            // buttonFilerAction
            // 
            this.buttonFilerAction.Location = new System.Drawing.Point(765, 179);
            this.buttonFilerAction.Name = "buttonFilerAction";
            this.buttonFilerAction.Size = new System.Drawing.Size(75, 23);
            this.buttonFilerAction.TabIndex = 7;
            this.buttonFilerAction.Text = "Filter";
            this.buttonFilerAction.UseVisualStyleBackColor = true;
            // 
            // WatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFilerAction);
            this.Controls.Add(this.textBoxFiler);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelJustParamater);
            this.Controls.Add(this.buttonDefaultFilter);
            this.Controls.Add(this.buttonDeleteFromWL);
            this.Controls.Add(this.buttonAddToWL);
            this.Controls.Add(this.listView1);
            this.Name = "WatchList";
            this.Size = new System.Drawing.Size(843, 456);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAddToWL;
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
        private System.Windows.Forms.TextBox textBoxFiler;
        private System.Windows.Forms.Button buttonFilerAction;
    }
}
