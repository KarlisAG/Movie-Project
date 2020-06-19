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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.comboBoxPlot = new System.Windows.Forms.ComboBox();
            this.labelPlot = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelSeason = new System.Windows.Forms.Label();
            this.labelEpisode = new System.Windows.Forms.Label();
            this.textBoxSeason = new System.Windows.Forms.TextBox();
            this.textBoxEpisode = new System.Windows.Forms.TextBox();
            this.labelSearchStatus = new System.Windows.Forms.Label();
            this.labelImdbID = new System.Windows.Forms.Label();
            this.labelOptional = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.labelNumberError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearchByID
            // 
            this.buttonSearchByID.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonSearchByID.Location = new System.Drawing.Point(148, 60);
            this.buttonSearchByID.Name = "buttonSearchByID";
            this.buttonSearchByID.Size = new System.Drawing.Size(94, 23);
            this.buttonSearchByID.TabIndex = 14;
            this.buttonSearchByID.Text = "Imdb ID";
            this.buttonSearchByID.UseVisualStyleBackColor = true;
            this.buttonSearchByID.Click += new System.EventHandler(this.buttonSearchByID_Click);
            // 
            // buttonSearchByTitle
            // 
            this.buttonSearchByTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonSearchByTitle.Location = new System.Drawing.Point(53, 60);
            this.buttonSearchByTitle.Name = "buttonSearchByTitle";
            this.buttonSearchByTitle.Size = new System.Drawing.Size(89, 23);
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
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonClear.Location = new System.Drawing.Point(576, 108);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonSearch.Location = new System.Drawing.Point(459, 108);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(111, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Visible = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(148, 111);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitle.TabIndex = 15;
            this.textBoxTitle.Visible = false;
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonAdvanced.Location = new System.Drawing.Point(148, 154);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(175, 25);
            this.buttonAdvanced.TabIndex = 16;
            this.buttonAdvanced.Text = "Show Advanced Search";
            this.buttonAdvanced.UseVisualStyleBackColor = true;
            this.buttonAdvanced.Visible = false;
            this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvanced_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(101, 112);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(41, 19);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Title:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTitle.Visible = false;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(332, 196);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(121, 20);
            this.textBoxYear.TabIndex = 18;
            this.textBoxYear.Visible = false;
            this.textBoxYear.TextChanged += new System.EventHandler(this.CheckNumber);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelYear.Location = new System.Drawing.Point(275, 197);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(51, 19);
            this.labelYear.TabIndex = 19;
            this.labelYear.Text = "* Year:";
            this.labelYear.Visible = false;
            // 
            // comboBoxPlot
            // 
            this.comboBoxPlot.FormattingEnabled = true;
            this.comboBoxPlot.Items.AddRange(new object[] {
            "Short",
            "Full"});
            this.comboBoxPlot.Location = new System.Drawing.Point(332, 110);
            this.comboBoxPlot.Name = "comboBoxPlot";
            this.comboBoxPlot.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlot.TabIndex = 20;
            this.comboBoxPlot.Visible = false;
            // 
            // labelPlot
            // 
            this.labelPlot.AutoSize = true;
            this.labelPlot.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelPlot.Location = new System.Drawing.Point(288, 112);
            this.labelPlot.Name = "labelPlot";
            this.labelPlot.Size = new System.Drawing.Size(38, 19);
            this.labelPlot.TabIndex = 21;
            this.labelPlot.Text = "Plot:";
            this.labelPlot.Visible = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelType.Location = new System.Drawing.Point(91, 197);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(51, 19);
            this.labelType.TabIndex = 23;
            this.labelType.Text = "* Type";
            this.labelType.Visible = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Movie",
            "Series"});
            this.comboBoxType.Location = new System.Drawing.Point(148, 197);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 22;
            this.comboBoxType.Visible = false;
            this.comboBoxType.TextChanged += new System.EventHandler(this.TypeChanged);
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelSeason.Location = new System.Drawing.Point(73, 240);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(69, 19);
            this.labelSeason.TabIndex = 24;
            this.labelSeason.Text = "* Season:";
            this.labelSeason.Visible = false;
            // 
            // labelEpisode
            // 
            this.labelEpisode.AutoSize = true;
            this.labelEpisode.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelEpisode.Location = new System.Drawing.Point(67, 266);
            this.labelEpisode.Name = "labelEpisode";
            this.labelEpisode.Size = new System.Drawing.Size(75, 19);
            this.labelEpisode.TabIndex = 25;
            this.labelEpisode.Text = "* Episode:";
            this.labelEpisode.Visible = false;
            // 
            // textBoxSeason
            // 
            this.textBoxSeason.Location = new System.Drawing.Point(148, 240);
            this.textBoxSeason.Name = "textBoxSeason";
            this.textBoxSeason.Size = new System.Drawing.Size(121, 20);
            this.textBoxSeason.TabIndex = 26;
            this.textBoxSeason.Visible = false;
            this.textBoxSeason.TextChanged += new System.EventHandler(this.CheckNumber);
            // 
            // textBoxEpisode
            // 
            this.textBoxEpisode.Location = new System.Drawing.Point(148, 266);
            this.textBoxEpisode.Name = "textBoxEpisode";
            this.textBoxEpisode.Size = new System.Drawing.Size(121, 20);
            this.textBoxEpisode.TabIndex = 27;
            this.textBoxEpisode.Visible = false;
            this.textBoxEpisode.TextChanged += new System.EventHandler(this.CheckNumber);
            // 
            // labelSearchStatus
            // 
            this.labelSearchStatus.AutoSize = true;
            this.labelSearchStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelSearchStatus.Location = new System.Drawing.Point(288, 9);
            this.labelSearchStatus.Name = "labelSearchStatus";
            this.labelSearchStatus.Size = new System.Drawing.Size(59, 19);
            this.labelSearchStatus.TabIndex = 28;
            this.labelSearchStatus.Text = "Success";
            this.labelSearchStatus.Visible = false;
            // 
            // labelImdbID
            // 
            this.labelImdbID.AutoSize = true;
            this.labelImdbID.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImdbID.Location = new System.Drawing.Point(76, 112);
            this.labelImdbID.Name = "labelImdbID";
            this.labelImdbID.Size = new System.Drawing.Size(66, 19);
            this.labelImdbID.TabIndex = 29;
            this.labelImdbID.Text = "Imdb ID:";
            this.labelImdbID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelImdbID.Visible = false;
            // 
            // labelOptional
            // 
            this.labelOptional.AutoSize = true;
            this.labelOptional.Location = new System.Drawing.Point(145, 295);
            this.labelOptional.Name = "labelOptional";
            this.labelOptional.Size = new System.Drawing.Size(87, 13);
            this.labelOptional.TabIndex = 30;
            this.labelOptional.Text = "* = optional fields";
            this.labelOptional.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(126, 343);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Location = new System.Drawing.Point(291, 38);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.labelErrorMessage.TabIndex = 32;
            this.labelErrorMessage.Visible = false;
            // 
            // labelNumberError
            // 
            this.labelNumberError.AutoSize = true;
            this.labelNumberError.Location = new System.Drawing.Point(276, 243);
            this.labelNumberError.Name = "labelNumberError";
            this.labelNumberError.Size = new System.Drawing.Size(0, 13);
            this.labelNumberError.TabIndex = 33;
            this.labelNumberError.Visible = false;
            // 
            // SearchUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNumberError);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelOptional);
            this.Controls.Add(this.labelImdbID);
            this.Controls.Add(this.labelSearchStatus);
            this.Controls.Add(this.textBoxEpisode);
            this.Controls.Add(this.textBoxSeason);
            this.Controls.Add(this.labelEpisode);
            this.Controls.Add(this.labelSeason);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelPlot);
            this.Controls.Add(this.comboBoxPlot);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonAdvanced);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonSearchByID);
            this.Controls.Add(this.buttonSearchByTitle);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
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
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonAdvanced;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboBoxPlot;
        private System.Windows.Forms.Label labelPlot;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label labelEpisode;
        private System.Windows.Forms.TextBox textBoxSeason;
        private System.Windows.Forms.TextBox textBoxEpisode;
        private System.Windows.Forms.Label labelSearchStatus;
        private System.Windows.Forms.Label labelImdbID;
        private System.Windows.Forms.Label labelOptional;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Label labelNumberError;
    }
}
