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
            this.labelSearchSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearchByID
            // 
            this.buttonSearchByID.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonSearchByID.Location = new System.Drawing.Point(53, 89);
            this.buttonSearchByID.Name = "buttonSearchByID";
            this.buttonSearchByID.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchByID.TabIndex = 14;
            this.buttonSearchByID.Text = "IMD ID";
            this.buttonSearchByID.UseVisualStyleBackColor = true;
            this.buttonSearchByID.Click += new System.EventHandler(this.buttonSearchByID_Click);
            // 
            // buttonSearchByTitle
            // 
            this.buttonSearchByTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonSearchByTitle.Location = new System.Drawing.Point(53, 60);
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
            this.labelSearchBy.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelSearchBy.Location = new System.Drawing.Point(52, 38);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(76, 19);
            this.labelSearchBy.TabIndex = 12;
            this.labelSearchBy.Text = "Search By:";
            this.labelSearchBy.Click += new System.EventHandler(this.labelSearchBy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonClear.Location = new System.Drawing.Point(432, 117);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearchMovie
            // 
            this.buttonSearchMovie.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonSearchMovie.Location = new System.Drawing.Point(351, 117);
            this.buttonSearchMovie.Name = "buttonSearchMovie";
            this.buttonSearchMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchMovie.TabIndex = 10;
            this.buttonSearchMovie.Text = "Search";
            this.buttonSearchMovie.UseVisualStyleBackColor = true;
            this.buttonSearchMovie.Click += new System.EventHandler(this.buttonSearchMovie_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(53, 118);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitle.TabIndex = 15;
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonAdvanced.Location = new System.Drawing.Point(53, 158);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(142, 23);
            this.buttonAdvanced.TabIndex = 16;
            this.buttonAdvanced.Text = "Advanced Search";
            this.buttonAdvanced.UseVisualStyleBackColor = true;
            this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvanced_Click);
            // 
            // labelTorIDParameter
            // 
            this.labelTorIDParameter.AutoSize = true;
            this.labelTorIDParameter.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTorIDParameter.Location = new System.Drawing.Point(3, 119);
            this.labelTorIDParameter.Name = "labelTorIDParameter";
            this.labelTorIDParameter.Size = new System.Drawing.Size(41, 19);
            this.labelTorIDParameter.TabIndex = 17;
            this.labelTorIDParameter.Text = "Title:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(248, 201);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(121, 20);
            this.textBoxYear.TabIndex = 18;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelYear.Location = new System.Drawing.Point(201, 203);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(41, 19);
            this.labelYear.TabIndex = 19;
            this.labelYear.Text = "Year:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Short",
            "Full"});
            this.comboBox1.Location = new System.Drawing.Point(224, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // labelPlot
            // 
            this.labelPlot.AutoSize = true;
            this.labelPlot.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelPlot.Location = new System.Drawing.Point(180, 119);
            this.labelPlot.Name = "labelPlot";
            this.labelPlot.Size = new System.Drawing.Size(38, 19);
            this.labelPlot.TabIndex = 21;
            this.labelPlot.Text = "Plot:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelType.Location = new System.Drawing.Point(24, 201);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(44, 19);
            this.labelType.TabIndex = 23;
            this.labelType.Text = "Type:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Movie",
            "Series"});
            this.comboBox2.Location = new System.Drawing.Point(74, 201);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelSeason.Location = new System.Drawing.Point(9, 244);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(59, 19);
            this.labelSeason.TabIndex = 24;
            this.labelSeason.Text = "Season:";
            // 
            // labelEpisode
            // 
            this.labelEpisode.AutoSize = true;
            this.labelEpisode.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelEpisode.Location = new System.Drawing.Point(3, 270);
            this.labelEpisode.Name = "labelEpisode";
            this.labelEpisode.Size = new System.Drawing.Size(65, 19);
            this.labelEpisode.TabIndex = 25;
            this.labelEpisode.Text = "Episode:";
            // 
            // textBoxSeason
            // 
            this.textBoxSeason.Location = new System.Drawing.Point(74, 244);
            this.textBoxSeason.Name = "textBoxSeason";
            this.textBoxSeason.Size = new System.Drawing.Size(121, 20);
            this.textBoxSeason.TabIndex = 26;
            // 
            // textBoxEpisode
            // 
            this.textBoxEpisode.Location = new System.Drawing.Point(74, 270);
            this.textBoxEpisode.Name = "textBoxEpisode";
            this.textBoxEpisode.Size = new System.Drawing.Size(121, 20);
            this.textBoxEpisode.TabIndex = 27;
            // 
            // labelSearchSuccess
            // 
            this.labelSearchSuccess.AutoSize = true;
            this.labelSearchSuccess.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelSearchSuccess.Location = new System.Drawing.Point(670, 42);
            this.labelSearchSuccess.Name = "labelSearchSuccess";
            this.labelSearchSuccess.Size = new System.Drawing.Size(59, 19);
            this.labelSearchSuccess.TabIndex = 28;
            this.labelSearchSuccess.Text = "Success";
            // 
            // SearchUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSearchSuccess);
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
            this.Size = new System.Drawing.Size(843, 456);
            this.Load += new System.EventHandler(this.SearchUC_Load);
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
        private System.Windows.Forms.Label labelSearchSuccess;
    }
}
