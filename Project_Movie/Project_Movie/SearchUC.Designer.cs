namespace Project_Movie
{
    partial class SearchUC
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
            this.buttonSearchByID = new System.Windows.Forms.Button();
            this.buttonSearchByTitle = new System.Windows.Forms.Button();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearchMovie = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.labelTorIDParameter = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelPlot = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelSeason = new System.Windows.Forms.Label();
            this.labelEpisode = new System.Windows.Forms.Label();
            this.textBoxSeason = new System.Windows.Forms.TextBox();
            this.textBoxEpisode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSearchByID
            // 
            this.buttonSearchByID.Location = new System.Drawing.Point(34, 89);
            this.buttonSearchByID.Name = "buttonSearchByID";
            this.buttonSearchByID.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchByID.TabIndex = 14;
            this.buttonSearchByID.Text = "IMD ID";
            this.buttonSearchByID.UseVisualStyleBackColor = true;
            this.buttonSearchByID.Click += new System.EventHandler(this.buttonSearchByID_Click);
            // 
            // buttonSearchByTitle
            // 
            this.buttonSearchByTitle.Location = new System.Drawing.Point(34, 60);
            this.buttonSearchByTitle.Name = "buttonSearchByTitle";
            this.buttonSearchByTitle.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchByTitle.TabIndex = 13;
            this.buttonSearchByTitle.Text = "Title";
            this.buttonSearchByTitle.UseVisualStyleBackColor = true;
            this.buttonSearchByTitle.Click += new System.EventHandler(this.buttonSearchByTitle_Click);
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(44, 42);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(59, 13);
            this.labelSearchBy.TabIndex = 12;
            this.labelSearchBy.Text = "Search By:";
            this.labelSearchBy.Click += new System.EventHandler(this.labelSearchBy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(569, 120);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearchMovie
            // 
            this.buttonSearchMovie.Location = new System.Drawing.Point(488, 120);
            this.buttonSearchMovie.Name = "buttonSearchMovie";
            this.buttonSearchMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchMovie.TabIndex = 10;
            this.buttonSearchMovie.Text = "Search";
            this.buttonSearchMovie.UseVisualStyleBackColor = true;
            this.buttonSearchMovie.Click += new System.EventHandler(this.buttonSearchMovie_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(200, 121);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitle.TabIndex = 15;
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.Location = new System.Drawing.Point(169, 172);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(113, 23);
            this.buttonAdvanced.TabIndex = 16;
            this.buttonAdvanced.Text = "Advanced Search";
            this.buttonAdvanced.UseVisualStyleBackColor = true;
            // 
            // labelTorIDParameter
            // 
            this.labelTorIDParameter.AutoSize = true;
            this.labelTorIDParameter.Location = new System.Drawing.Point(164, 128);
            this.labelTorIDParameter.Name = "labelTorIDParameter";
            this.labelTorIDParameter.Size = new System.Drawing.Size(30, 13);
            this.labelTorIDParameter.TabIndex = 17;
            this.labelTorIDParameter.Text = "Title:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(361, 206);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(121, 20);
            this.textBoxYear.TabIndex = 18;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(327, 213);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 19;
            this.labelYear.Text = "Year:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Short",
            "Full"});
            this.comboBox1.Location = new System.Drawing.Point(361, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // labelPlot
            // 
            this.labelPlot.AutoSize = true;
            this.labelPlot.Location = new System.Drawing.Point(327, 128);
            this.labelPlot.Name = "labelPlot";
            this.labelPlot.Size = new System.Drawing.Size(28, 13);
            this.labelPlot.TabIndex = 21;
            this.labelPlot.Text = "Plot:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(166, 213);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 23;
            this.labelType.Text = "Type:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Movie",
            "Series"});
            this.comboBox2.Location = new System.Drawing.Point(200, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Location = new System.Drawing.Point(153, 251);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(46, 13);
            this.labelSeason.TabIndex = 24;
            this.labelSeason.Text = "Season:";
            // 
            // labelEpisode
            // 
            this.labelEpisode.AutoSize = true;
            this.labelEpisode.Location = new System.Drawing.Point(153, 277);
            this.labelEpisode.Name = "labelEpisode";
            this.labelEpisode.Size = new System.Drawing.Size(48, 13);
            this.labelEpisode.TabIndex = 25;
            this.labelEpisode.Text = "Episode:";
            // 
            // textBoxSeason
            // 
            this.textBoxSeason.Location = new System.Drawing.Point(200, 248);
            this.textBoxSeason.Name = "textBoxSeason";
            this.textBoxSeason.Size = new System.Drawing.Size(121, 20);
            this.textBoxSeason.TabIndex = 26;
            // 
            // textBoxEpisode
            // 
            this.textBoxEpisode.Location = new System.Drawing.Point(200, 274);
            this.textBoxEpisode.Name = "textBoxEpisode";
            this.textBoxEpisode.Size = new System.Drawing.Size(121, 20);
            this.textBoxEpisode.TabIndex = 27;
            // 
            // SearchUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxEpisode);
            this.Controls.Add(this.textBoxSeason);
            this.Controls.Add(this.labelEpisode);
            this.Controls.Add(this.labelSeason);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelPlot);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelTorIDParameter);
            this.Controls.Add(this.buttonAdvanced);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonSearchByID);
            this.Controls.Add(this.buttonSearchByTitle);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearchMovie);
            this.Name = "SearchUC";
            this.Size = new System.Drawing.Size(998, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchByID;
        private System.Windows.Forms.Button buttonSearchByTitle;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearchMovie;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonAdvanced;
        private System.Windows.Forms.Label labelTorIDParameter;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPlot;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label labelEpisode;
        private System.Windows.Forms.TextBox textBoxSeason;
        private System.Windows.Forms.TextBox textBoxEpisode;
    }
}
