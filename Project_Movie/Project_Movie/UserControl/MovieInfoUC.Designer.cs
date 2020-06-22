namespace Project_Movie
{
    partial class InfoUC
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
            this.components = new System.ComponentModel.Container();
            this.labelInfoTitle = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelJustYear = new System.Windows.Forms.Label();
            this.labelJustMetascore = new System.Windows.Forms.Label();
            this.labelJustGenre = new System.Windows.Forms.Label();
            this.labelJustActors = new System.Windows.Forms.Label();
            this.labelJustRuntime = new System.Windows.Forms.Label();
            this.labelJustCountry = new System.Windows.Forms.Label();
            this.labelJustProduction = new System.Windows.Forms.Label();
            this.labelJustPlot = new System.Windows.Forms.Label();
            this.buttonExtraIMDBInfo = new System.Windows.Forms.Button();
            this.buttonExtraRatings = new System.Windows.Forms.Button();
            this.labelJustIMDB_ID = new System.Windows.Forms.Label();
            this.labelJustImdbRating = new System.Windows.Forms.Label();
            this.labelJustImdbVotes = new System.Windows.Forms.Label();
            this.labelJustWriter = new System.Windows.Forms.Label();
            this.listViewRatings = new System.Windows.Forms.ListView();
            this.Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabelImdb = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelJustType = new System.Windows.Forms.Label();
            this.labelJustRated = new System.Windows.Forms.Label();
            this.buttonSaveToWatchlist = new System.Windows.Forms.Button();
            this.richTextBoxInfoGenres = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoPlot = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoActors = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoType = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoMetascore = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoYear = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoRated = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoWriter = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoProduction = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoCountry = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoRuntime = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoImdbID = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoImdbRating = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInfoImdbVotes = new System.Windows.Forms.RichTextBox();
            this.labelJustLinkToImdb = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfoTitle
            // 
            this.labelInfoTitle.AutoSize = true;
            this.labelInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelInfoTitle.Location = new System.Drawing.Point(217, 1);
            this.labelInfoTitle.Name = "labelInfoTitle";
            this.labelInfoTitle.Size = new System.Drawing.Size(82, 37);
            this.labelInfoTitle.TabIndex = 0;
            this.labelInfoTitle.Text = "Title";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelJustYear
            // 
            this.labelJustYear.AutoSize = true;
            this.labelJustYear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustYear.Location = new System.Drawing.Point(222, 61);
            this.labelJustYear.Name = "labelJustYear";
            this.labelJustYear.Size = new System.Drawing.Size(48, 21);
            this.labelJustYear.TabIndex = 1;
            this.labelJustYear.Text = "Year:";
            // 
            // labelJustMetascore
            // 
            this.labelJustMetascore.AutoSize = true;
            this.labelJustMetascore.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustMetascore.Location = new System.Drawing.Point(222, 105);
            this.labelJustMetascore.Name = "labelJustMetascore";
            this.labelJustMetascore.Size = new System.Drawing.Size(93, 21);
            this.labelJustMetascore.TabIndex = 4;
            this.labelJustMetascore.Text = "Metascore:";
            // 
            // labelJustGenre
            // 
            this.labelJustGenre.AutoSize = true;
            this.labelJustGenre.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustGenre.Location = new System.Drawing.Point(222, 149);
            this.labelJustGenre.Name = "labelJustGenre";
            this.labelJustGenre.Size = new System.Drawing.Size(59, 21);
            this.labelJustGenre.TabIndex = 6;
            this.labelJustGenre.Text = "Genre:";
            // 
            // labelJustActors
            // 
            this.labelJustActors.AutoSize = true;
            this.labelJustActors.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustActors.Location = new System.Drawing.Point(222, 193);
            this.labelJustActors.Name = "labelJustActors";
            this.labelJustActors.Size = new System.Drawing.Size(62, 21);
            this.labelJustActors.TabIndex = 8;
            this.labelJustActors.Text = "Actors:";
            // 
            // labelJustRuntime
            // 
            this.labelJustRuntime.AutoSize = true;
            this.labelJustRuntime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustRuntime.Location = new System.Drawing.Point(529, 61);
            this.labelJustRuntime.Name = "labelJustRuntime";
            this.labelJustRuntime.Size = new System.Drawing.Size(79, 21);
            this.labelJustRuntime.TabIndex = 10;
            this.labelJustRuntime.Text = "Runtime:";
            // 
            // labelJustCountry
            // 
            this.labelJustCountry.AutoSize = true;
            this.labelJustCountry.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustCountry.Location = new System.Drawing.Point(529, 105);
            this.labelJustCountry.Name = "labelJustCountry";
            this.labelJustCountry.Size = new System.Drawing.Size(75, 21);
            this.labelJustCountry.TabIndex = 14;
            this.labelJustCountry.Text = "Country:";
            // 
            // labelJustProduction
            // 
            this.labelJustProduction.AutoSize = true;
            this.labelJustProduction.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustProduction.Location = new System.Drawing.Point(529, 149);
            this.labelJustProduction.Name = "labelJustProduction";
            this.labelJustProduction.Size = new System.Drawing.Size(99, 21);
            this.labelJustProduction.TabIndex = 16;
            this.labelJustProduction.Text = "Production:";
            // 
            // labelJustPlot
            // 
            this.labelJustPlot.AutoSize = true;
            this.labelJustPlot.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustPlot.Location = new System.Drawing.Point(3, 287);
            this.labelJustPlot.Name = "labelJustPlot";
            this.labelJustPlot.Size = new System.Drawing.Size(45, 21);
            this.labelJustPlot.TabIndex = 18;
            this.labelJustPlot.Text = "Plot:";
            // 
            // buttonExtraIMDBInfo
            // 
            this.buttonExtraIMDBInfo.Location = new System.Drawing.Point(332, 285);
            this.buttonExtraIMDBInfo.Name = "buttonExtraIMDBInfo";
            this.buttonExtraIMDBInfo.Size = new System.Drawing.Size(106, 23);
            this.buttonExtraIMDBInfo.TabIndex = 20;
            this.buttonExtraIMDBInfo.Text = "More Imdb Info";
            this.buttonExtraIMDBInfo.UseVisualStyleBackColor = true;
            this.buttonExtraIMDBInfo.Click += new System.EventHandler(this.buttonExtraIMDBInfo_Click);
            // 
            // buttonExtraRatings
            // 
            this.buttonExtraRatings.Location = new System.Drawing.Point(734, 285);
            this.buttonExtraRatings.Name = "buttonExtraRatings";
            this.buttonExtraRatings.Size = new System.Drawing.Size(106, 23);
            this.buttonExtraRatings.TabIndex = 21;
            this.buttonExtraRatings.Text = "More Ratings";
            this.buttonExtraRatings.UseVisualStyleBackColor = true;
            this.buttonExtraRatings.Click += new System.EventHandler(this.buttonExtraRatings_Click);
            // 
            // labelJustIMDB_ID
            // 
            this.labelJustIMDB_ID.AutoSize = true;
            this.labelJustIMDB_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelJustIMDB_ID.Location = new System.Drawing.Point(333, 311);
            this.labelJustIMDB_ID.Name = "labelJustIMDB_ID";
            this.labelJustIMDB_ID.Size = new System.Drawing.Size(73, 20);
            this.labelJustIMDB_ID.TabIndex = 22;
            this.labelJustIMDB_ID.Text = "ImdbID:";
            this.labelJustIMDB_ID.Visible = false;
            // 
            // labelJustImdbRating
            // 
            this.labelJustImdbRating.AutoSize = true;
            this.labelJustImdbRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelJustImdbRating.Location = new System.Drawing.Point(333, 339);
            this.labelJustImdbRating.Name = "labelJustImdbRating";
            this.labelJustImdbRating.Size = new System.Drawing.Size(112, 20);
            this.labelJustImdbRating.TabIndex = 23;
            this.labelJustImdbRating.Text = "Imdb Rating:";
            this.labelJustImdbRating.Visible = false;
            // 
            // labelJustImdbVotes
            // 
            this.labelJustImdbVotes.AutoSize = true;
            this.labelJustImdbVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelJustImdbVotes.Location = new System.Drawing.Point(333, 367);
            this.labelJustImdbVotes.Name = "labelJustImdbVotes";
            this.labelJustImdbVotes.Size = new System.Drawing.Size(106, 20);
            this.labelJustImdbVotes.TabIndex = 24;
            this.labelJustImdbVotes.Text = "Imdb Votes:";
            this.labelJustImdbVotes.Visible = false;
            // 
            // labelJustWriter
            // 
            this.labelJustWriter.AutoSize = true;
            this.labelJustWriter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustWriter.Location = new System.Drawing.Point(529, 193);
            this.labelJustWriter.Name = "labelJustWriter";
            this.labelJustWriter.Size = new System.Drawing.Size(62, 21);
            this.labelJustWriter.TabIndex = 31;
            this.labelJustWriter.Text = "Writer:";
            // 
            // listViewRatings
            // 
            this.listViewRatings.BackColor = System.Drawing.Color.Cornsilk;
            this.listViewRatings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRatings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Source,
            this.Value});
            this.listViewRatings.HideSelection = false;
            this.listViewRatings.Location = new System.Drawing.Point(549, 314);
            this.listViewRatings.Name = "listViewRatings";
            this.listViewRatings.Size = new System.Drawing.Size(294, 141);
            this.listViewRatings.TabIndex = 33;
            this.listViewRatings.UseCompatibleStateImageBehavior = false;
            this.listViewRatings.View = System.Windows.Forms.View.Details;
            this.listViewRatings.Visible = false;
            // 
            // Source
            // 
            this.Source.Text = "Source";
            this.Source.Width = 197;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 95;
            // 
            // linkLabelImdb
            // 
            this.linkLabelImdb.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabelImdb.AutoSize = true;
            this.linkLabelImdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.linkLabelImdb.Location = new System.Drawing.Point(617, 263);
            this.linkLabelImdb.Name = "linkLabelImdb";
            this.linkLabelImdb.Size = new System.Drawing.Size(74, 15);
            this.linkLabelImdb.TabIndex = 35;
            this.linkLabelImdb.TabStop = true;
            this.linkLabelImdb.Text = "Link to Imdb";
            this.linkLabelImdb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelImdb_LinkClicked);
            // 
            // labelJustType
            // 
            this.labelJustType.AutoSize = true;
            this.labelJustType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.labelJustType.Location = new System.Drawing.Point(222, 237);
            this.labelJustType.Name = "labelJustType";
            this.labelJustType.Size = new System.Drawing.Size(51, 21);
            this.labelJustType.TabIndex = 38;
            this.labelJustType.Text = "Type:";
            // 
            // labelJustRated
            // 
            this.labelJustRated.AutoSize = true;
            this.labelJustRated.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.labelJustRated.Location = new System.Drawing.Point(529, 237);
            this.labelJustRated.Name = "labelJustRated";
            this.labelJustRated.Size = new System.Drawing.Size(58, 21);
            this.labelJustRated.TabIndex = 39;
            this.labelJustRated.Text = "Rated:";
            // 
            // buttonSaveToWatchlist
            // 
            this.buttonSaveToWatchlist.Location = new System.Drawing.Point(607, 285);
            this.buttonSaveToWatchlist.Name = "buttonSaveToWatchlist";
            this.buttonSaveToWatchlist.Size = new System.Drawing.Size(121, 23);
            this.buttonSaveToWatchlist.TabIndex = 40;
            this.buttonSaveToWatchlist.Text = "Save To Watch List";
            this.buttonSaveToWatchlist.UseVisualStyleBackColor = true;
            this.buttonSaveToWatchlist.Click += new System.EventHandler(this.buttonSaveToWatchlist_Click);
            // 
            // richTextBoxInfoGenres
            // 
            this.richTextBoxInfoGenres.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoGenres.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoGenres.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoGenres.Location = new System.Drawing.Point(329, 149);
            this.richTextBoxInfoGenres.Name = "richTextBoxInfoGenres";
            this.richTextBoxInfoGenres.ReadOnly = true;
            this.richTextBoxInfoGenres.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoGenres.TabIndex = 46;
            this.richTextBoxInfoGenres.Text = "";
            // 
            // richTextBoxInfoPlot
            // 
            this.richTextBoxInfoPlot.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoPlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoPlot.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoPlot.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoPlot.Location = new System.Drawing.Point(54, 285);
            this.richTextBoxInfoPlot.Name = "richTextBoxInfoPlot";
            this.richTextBoxInfoPlot.ReadOnly = true;
            this.richTextBoxInfoPlot.Size = new System.Drawing.Size(272, 165);
            this.richTextBoxInfoPlot.TabIndex = 47;
            this.richTextBoxInfoPlot.Text = "";
            // 
            // richTextBoxInfoActors
            // 
            this.richTextBoxInfoActors.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoActors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoActors.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoActors.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoActors.Location = new System.Drawing.Point(329, 193);
            this.richTextBoxInfoActors.Name = "richTextBoxInfoActors";
            this.richTextBoxInfoActors.ReadOnly = true;
            this.richTextBoxInfoActors.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoActors.TabIndex = 48;
            this.richTextBoxInfoActors.Text = "";
            // 
            // richTextBoxInfoType
            // 
            this.richTextBoxInfoType.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoType.Location = new System.Drawing.Point(329, 237);
            this.richTextBoxInfoType.Name = "richTextBoxInfoType";
            this.richTextBoxInfoType.ReadOnly = true;
            this.richTextBoxInfoType.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoType.TabIndex = 49;
            this.richTextBoxInfoType.Text = "";
            // 
            // richTextBoxInfoMetascore
            // 
            this.richTextBoxInfoMetascore.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoMetascore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoMetascore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoMetascore.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoMetascore.Location = new System.Drawing.Point(329, 105);
            this.richTextBoxInfoMetascore.Name = "richTextBoxInfoMetascore";
            this.richTextBoxInfoMetascore.ReadOnly = true;
            this.richTextBoxInfoMetascore.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoMetascore.TabIndex = 50;
            this.richTextBoxInfoMetascore.Text = "";
            // 
            // richTextBoxInfoYear
            // 
            this.richTextBoxInfoYear.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoYear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoYear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoYear.Location = new System.Drawing.Point(329, 61);
            this.richTextBoxInfoYear.Name = "richTextBoxInfoYear";
            this.richTextBoxInfoYear.ReadOnly = true;
            this.richTextBoxInfoYear.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoYear.TabIndex = 51;
            this.richTextBoxInfoYear.Text = "";
            // 
            // richTextBoxInfoRated
            // 
            this.richTextBoxInfoRated.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoRated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoRated.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoRated.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoRated.Location = new System.Drawing.Point(641, 237);
            this.richTextBoxInfoRated.Name = "richTextBoxInfoRated";
            this.richTextBoxInfoRated.ReadOnly = true;
            this.richTextBoxInfoRated.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoRated.TabIndex = 52;
            this.richTextBoxInfoRated.Text = "";
            // 
            // richTextBoxInfoWriter
            // 
            this.richTextBoxInfoWriter.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoWriter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoWriter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoWriter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoWriter.Location = new System.Drawing.Point(641, 193);
            this.richTextBoxInfoWriter.Name = "richTextBoxInfoWriter";
            this.richTextBoxInfoWriter.ReadOnly = true;
            this.richTextBoxInfoWriter.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoWriter.TabIndex = 53;
            this.richTextBoxInfoWriter.Text = "";
            // 
            // richTextBoxInfoProduction
            // 
            this.richTextBoxInfoProduction.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoProduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoProduction.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoProduction.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoProduction.Location = new System.Drawing.Point(641, 149);
            this.richTextBoxInfoProduction.Name = "richTextBoxInfoProduction";
            this.richTextBoxInfoProduction.ReadOnly = true;
            this.richTextBoxInfoProduction.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoProduction.TabIndex = 54;
            this.richTextBoxInfoProduction.Text = "";
            // 
            // richTextBoxInfoCountry
            // 
            this.richTextBoxInfoCountry.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoCountry.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoCountry.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoCountry.Location = new System.Drawing.Point(641, 105);
            this.richTextBoxInfoCountry.Name = "richTextBoxInfoCountry";
            this.richTextBoxInfoCountry.ReadOnly = true;
            this.richTextBoxInfoCountry.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoCountry.TabIndex = 55;
            this.richTextBoxInfoCountry.Text = "";
            // 
            // richTextBoxInfoRuntime
            // 
            this.richTextBoxInfoRuntime.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoRuntime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoRuntime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoRuntime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoRuntime.Location = new System.Drawing.Point(641, 61);
            this.richTextBoxInfoRuntime.Name = "richTextBoxInfoRuntime";
            this.richTextBoxInfoRuntime.ReadOnly = true;
            this.richTextBoxInfoRuntime.Size = new System.Drawing.Size(195, 21);
            this.richTextBoxInfoRuntime.TabIndex = 56;
            this.richTextBoxInfoRuntime.Text = "";
            // 
            // richTextBoxInfoImdbID
            // 
            this.richTextBoxInfoImdbID.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoImdbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoImdbID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoImdbID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoImdbID.Location = new System.Drawing.Point(449, 310);
            this.richTextBoxInfoImdbID.Name = "richTextBoxInfoImdbID";
            this.richTextBoxInfoImdbID.ReadOnly = true;
            this.richTextBoxInfoImdbID.Size = new System.Drawing.Size(91, 21);
            this.richTextBoxInfoImdbID.TabIndex = 57;
            this.richTextBoxInfoImdbID.Text = "";
            this.richTextBoxInfoImdbID.Visible = false;
            // 
            // richTextBoxInfoImdbRating
            // 
            this.richTextBoxInfoImdbRating.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoImdbRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoImdbRating.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoImdbRating.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoImdbRating.Location = new System.Drawing.Point(449, 337);
            this.richTextBoxInfoImdbRating.Name = "richTextBoxInfoImdbRating";
            this.richTextBoxInfoImdbRating.ReadOnly = true;
            this.richTextBoxInfoImdbRating.Size = new System.Drawing.Size(91, 21);
            this.richTextBoxInfoImdbRating.TabIndex = 58;
            this.richTextBoxInfoImdbRating.Text = "";
            this.richTextBoxInfoImdbRating.Visible = false;
            // 
            // richTextBoxInfoImdbVotes
            // 
            this.richTextBoxInfoImdbVotes.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBoxInfoImdbVotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoImdbVotes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxInfoImdbVotes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.richTextBoxInfoImdbVotes.Location = new System.Drawing.Point(449, 368);
            this.richTextBoxInfoImdbVotes.Name = "richTextBoxInfoImdbVotes";
            this.richTextBoxInfoImdbVotes.ReadOnly = true;
            this.richTextBoxInfoImdbVotes.Size = new System.Drawing.Size(91, 21);
            this.richTextBoxInfoImdbVotes.TabIndex = 59;
            this.richTextBoxInfoImdbVotes.Text = "";
            this.richTextBoxInfoImdbVotes.Visible = false;
            // 
            // labelJustLinkToImdb
            // 
            this.labelJustLinkToImdb.AutoSize = true;
            this.labelJustLinkToImdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelJustLinkToImdb.Location = new System.Drawing.Point(530, 263);
            this.labelJustLinkToImdb.Name = "labelJustLinkToImdb";
            this.labelJustLinkToImdb.Size = new System.Drawing.Size(81, 15);
            this.labelJustLinkToImdb.TabIndex = 60;
            this.labelJustLinkToImdb.Text = "Link To Imdb:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(222, 40);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 21);
            this.labelError.TabIndex = 61;
            this.labelError.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // InfoUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelJustLinkToImdb);
            this.Controls.Add(this.richTextBoxInfoImdbVotes);
            this.Controls.Add(this.richTextBoxInfoImdbRating);
            this.Controls.Add(this.richTextBoxInfoImdbID);
            this.Controls.Add(this.richTextBoxInfoRuntime);
            this.Controls.Add(this.richTextBoxInfoCountry);
            this.Controls.Add(this.richTextBoxInfoProduction);
            this.Controls.Add(this.richTextBoxInfoWriter);
            this.Controls.Add(this.richTextBoxInfoRated);
            this.Controls.Add(this.richTextBoxInfoYear);
            this.Controls.Add(this.richTextBoxInfoMetascore);
            this.Controls.Add(this.richTextBoxInfoType);
            this.Controls.Add(this.richTextBoxInfoActors);
            this.Controls.Add(this.richTextBoxInfoPlot);
            this.Controls.Add(this.richTextBoxInfoGenres);
            this.Controls.Add(this.buttonSaveToWatchlist);
            this.Controls.Add(this.labelJustRated);
            this.Controls.Add(this.labelJustType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelImdb);
            this.Controls.Add(this.listViewRatings);
            this.Controls.Add(this.labelJustWriter);
            this.Controls.Add(this.labelJustImdbVotes);
            this.Controls.Add(this.labelJustImdbRating);
            this.Controls.Add(this.labelJustIMDB_ID);
            this.Controls.Add(this.buttonExtraRatings);
            this.Controls.Add(this.buttonExtraIMDBInfo);
            this.Controls.Add(this.labelJustPlot);
            this.Controls.Add(this.labelJustProduction);
            this.Controls.Add(this.labelJustCountry);
            this.Controls.Add(this.labelJustRuntime);
            this.Controls.Add(this.labelJustActors);
            this.Controls.Add(this.labelJustGenre);
            this.Controls.Add(this.labelJustMetascore);
            this.Controls.Add(this.labelJustYear);
            this.Controls.Add(this.labelInfoTitle);
            this.Name = "InfoUC";
            this.Size = new System.Drawing.Size(843, 456);
            this.VisibleChanged += new System.EventHandler(this.Update);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoTitle;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelJustYear;
        private System.Windows.Forms.Label labelJustMetascore;
        private System.Windows.Forms.Label labelJustGenre;
        private System.Windows.Forms.Label labelJustActors;
        private System.Windows.Forms.Label labelJustRuntime;
        private System.Windows.Forms.Label labelJustCountry;
        private System.Windows.Forms.Label labelJustProduction;
        private System.Windows.Forms.Label labelJustPlot;
        private System.Windows.Forms.Button buttonExtraIMDBInfo;
        private System.Windows.Forms.Button buttonExtraRatings;
        private System.Windows.Forms.Label labelJustIMDB_ID;
        private System.Windows.Forms.Label labelJustImdbRating;
        private System.Windows.Forms.Label labelJustImdbVotes;
        private System.Windows.Forms.Label labelJustWriter;
        private System.Windows.Forms.ListView listViewRatings;
        private System.Windows.Forms.LinkLabel linkLabelImdb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Source;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Label labelJustType;
        private System.Windows.Forms.Label labelJustRated;
        private System.Windows.Forms.Button buttonSaveToWatchlist;
        private System.Windows.Forms.RichTextBox richTextBoxInfoGenres;
        private System.Windows.Forms.RichTextBox richTextBoxInfoPlot;
        private System.Windows.Forms.RichTextBox richTextBoxInfoActors;
        private System.Windows.Forms.RichTextBox richTextBoxInfoType;
        private System.Windows.Forms.RichTextBox richTextBoxInfoMetascore;
        private System.Windows.Forms.RichTextBox richTextBoxInfoYear;
        private System.Windows.Forms.RichTextBox richTextBoxInfoRated;
        private System.Windows.Forms.RichTextBox richTextBoxInfoWriter;
        private System.Windows.Forms.RichTextBox richTextBoxInfoProduction;
        private System.Windows.Forms.RichTextBox richTextBoxInfoCountry;
        private System.Windows.Forms.RichTextBox richTextBoxInfoRuntime;
        private System.Windows.Forms.RichTextBox richTextBoxInfoImdbID;
        private System.Windows.Forms.RichTextBox richTextBoxInfoImdbRating;
        private System.Windows.Forms.RichTextBox richTextBoxInfoImdbVotes;
        private System.Windows.Forms.Label labelJustLinkToImdb;
        private System.Windows.Forms.Label labelError;
    }
}
