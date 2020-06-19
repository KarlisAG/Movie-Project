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
            this.labelInfoYear = new System.Windows.Forms.Label();
            this.labelInfoMetascore = new System.Windows.Forms.Label();
            this.labelJustMetascore = new System.Windows.Forms.Label();
            this.labelInfoGenre = new System.Windows.Forms.Label();
            this.labelJustGenre = new System.Windows.Forms.Label();
            this.labelInforActors = new System.Windows.Forms.Label();
            this.labelJustActors = new System.Windows.Forms.Label();
            this.labelInfoRuntime = new System.Windows.Forms.Label();
            this.labelJustRuntime = new System.Windows.Forms.Label();
            this.labelInfoType = new System.Windows.Forms.Label();
            this.labelInfoRated = new System.Windows.Forms.Label();
            this.labelInfoCountry = new System.Windows.Forms.Label();
            this.labelJustCountry = new System.Windows.Forms.Label();
            this.labelInfoProduction = new System.Windows.Forms.Label();
            this.labelJustProduction = new System.Windows.Forms.Label();
            this.labelInfoPlot = new System.Windows.Forms.Label();
            this.labelJustPlot = new System.Windows.Forms.Label();
            this.buttonExtraIMDBInfo = new System.Windows.Forms.Button();
            this.buttonExtraRatings = new System.Windows.Forms.Button();
            this.labelJustIMDB_ID = new System.Windows.Forms.Label();
            this.labelJustImdbRating = new System.Windows.Forms.Label();
            this.labelJustImdbVotes = new System.Windows.Forms.Label();
            this.labelInfoImdbVotes = new System.Windows.Forms.Label();
            this.labelInfoImdbRating = new System.Windows.Forms.Label();
            this.labelInfoImdbID = new System.Windows.Forms.Label();
            this.labelInfoWriter = new System.Windows.Forms.Label();
            this.labelJustWriter = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelImdb = new System.Windows.Forms.LinkLabel();
            this.labelJustImdbLink = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelJustType = new System.Windows.Forms.Label();
            this.labelJustRated = new System.Windows.Forms.Label();
            this.buttonSaveToWatchlist = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfoTitle
            // 
            this.labelInfoTitle.AutoSize = true;
            this.labelInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelInfoTitle.Location = new System.Drawing.Point(219, 9);
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
            // labelInfoYear
            // 
            this.labelInfoYear.AutoSize = true;
            this.labelInfoYear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoYear.Location = new System.Drawing.Point(328, 61);
            this.labelInfoYear.Name = "labelInfoYear";
            this.labelInfoYear.Size = new System.Drawing.Size(46, 21);
            this.labelInfoYear.TabIndex = 3;
            this.labelInfoYear.Text = "year..";
            // 
            // labelInfoMetascore
            // 
            this.labelInfoMetascore.AutoSize = true;
            this.labelInfoMetascore.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoMetascore.Location = new System.Drawing.Point(328, 105);
            this.labelInfoMetascore.Name = "labelInfoMetascore";
            this.labelInfoMetascore.Size = new System.Drawing.Size(91, 21);
            this.labelInfoMetascore.TabIndex = 5;
            this.labelInfoMetascore.Text = "metascore...";
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
            // labelInfoGenre
            // 
            this.labelInfoGenre.AutoSize = true;
            this.labelInfoGenre.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoGenre.Location = new System.Drawing.Point(328, 149);
            this.labelInfoGenre.Name = "labelInfoGenre";
            this.labelInfoGenre.Size = new System.Drawing.Size(56, 21);
            this.labelInfoGenre.TabIndex = 7;
            this.labelInfoGenre.Text = "genre..";
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
            // labelInforActors
            // 
            this.labelInforActors.AutoSize = true;
            this.labelInforActors.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInforActors.Location = new System.Drawing.Point(328, 193);
            this.labelInforActors.Name = "labelInforActors";
            this.labelInforActors.Size = new System.Drawing.Size(58, 21);
            this.labelInforActors.TabIndex = 9;
            this.labelInforActors.Text = "actors..";
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
            // labelInfoRuntime
            // 
            this.labelInfoRuntime.AutoSize = true;
            this.labelInfoRuntime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoRuntime.Location = new System.Drawing.Point(553, 61);
            this.labelInfoRuntime.Name = "labelInfoRuntime";
            this.labelInfoRuntime.Size = new System.Drawing.Size(71, 21);
            this.labelInfoRuntime.TabIndex = 11;
            this.labelInfoRuntime.Text = "runtime..";
            // 
            // labelJustRuntime
            // 
            this.labelJustRuntime.AutoSize = true;
            this.labelJustRuntime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustRuntime.Location = new System.Drawing.Point(445, 61);
            this.labelJustRuntime.Name = "labelJustRuntime";
            this.labelJustRuntime.Size = new System.Drawing.Size(79, 21);
            this.labelJustRuntime.TabIndex = 10;
            this.labelJustRuntime.Text = "Runtime:";
            // 
            // labelInfoType
            // 
            this.labelInfoType.AutoSize = true;
            this.labelInfoType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.labelInfoType.Location = new System.Drawing.Point(328, 237);
            this.labelInfoType.Name = "labelInfoType";
            this.labelInfoType.Size = new System.Drawing.Size(46, 21);
            this.labelInfoType.TabIndex = 12;
            this.labelInfoType.Text = "type..";
            // 
            // labelInfoRated
            // 
            this.labelInfoRated.AutoSize = true;
            this.labelInfoRated.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.labelInfoRated.Location = new System.Drawing.Point(553, 237);
            this.labelInfoRated.Name = "labelInfoRated";
            this.labelInfoRated.Size = new System.Drawing.Size(52, 21);
            this.labelInfoRated.TabIndex = 13;
            this.labelInfoRated.Text = "rated..";
            // 
            // labelInfoCountry
            // 
            this.labelInfoCountry.AutoSize = true;
            this.labelInfoCountry.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoCountry.Location = new System.Drawing.Point(553, 105);
            this.labelInfoCountry.Name = "labelInfoCountry";
            this.labelInfoCountry.Size = new System.Drawing.Size(69, 21);
            this.labelInfoCountry.TabIndex = 15;
            this.labelInfoCountry.Text = "country..";
            // 
            // labelJustCountry
            // 
            this.labelJustCountry.AutoSize = true;
            this.labelJustCountry.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustCountry.Location = new System.Drawing.Point(445, 105);
            this.labelJustCountry.Name = "labelJustCountry";
            this.labelJustCountry.Size = new System.Drawing.Size(75, 21);
            this.labelJustCountry.TabIndex = 14;
            this.labelJustCountry.Text = "Country:";
            // 
            // labelInfoProduction
            // 
            this.labelInfoProduction.AutoSize = true;
            this.labelInfoProduction.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoProduction.Location = new System.Drawing.Point(553, 149);
            this.labelInfoProduction.Name = "labelInfoProduction";
            this.labelInfoProduction.Size = new System.Drawing.Size(92, 21);
            this.labelInfoProduction.TabIndex = 17;
            this.labelInfoProduction.Text = "production..";
            // 
            // labelJustProduction
            // 
            this.labelJustProduction.AutoSize = true;
            this.labelJustProduction.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustProduction.Location = new System.Drawing.Point(445, 149);
            this.labelJustProduction.Name = "labelJustProduction";
            this.labelJustProduction.Size = new System.Drawing.Size(99, 21);
            this.labelJustProduction.TabIndex = 16;
            this.labelJustProduction.Text = "Production:";
            // 
            // labelInfoPlot
            // 
            this.labelInfoPlot.AutoSize = true;
            this.labelInfoPlot.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.labelInfoPlot.Location = new System.Drawing.Point(3, 1);
            this.labelInfoPlot.Name = "labelInfoPlot";
            this.labelInfoPlot.Size = new System.Drawing.Size(40, 21);
            this.labelInfoPlot.TabIndex = 19;
            this.labelInfoPlot.Text = "plot:";
            // 
            // labelJustPlot
            // 
            this.labelJustPlot.AutoSize = true;
            this.labelJustPlot.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.labelJustPlot.Location = new System.Drawing.Point(3, 287);
            this.labelJustPlot.Name = "labelJustPlot";
            this.labelJustPlot.Size = new System.Drawing.Size(40, 21);
            this.labelJustPlot.TabIndex = 18;
            this.labelJustPlot.Text = "Plot:";
            // 
            // buttonExtraIMDBInfo
            // 
            this.buttonExtraIMDBInfo.Location = new System.Drawing.Point(332, 285);
            this.buttonExtraIMDBInfo.Name = "buttonExtraIMDBInfo";
            this.buttonExtraIMDBInfo.Size = new System.Drawing.Size(106, 23);
            this.buttonExtraIMDBInfo.TabIndex = 20;
            this.buttonExtraIMDBInfo.Text = "More imdb Info";
            this.buttonExtraIMDBInfo.UseVisualStyleBackColor = true;
            // 
            // buttonExtraRatings
            // 
            this.buttonExtraRatings.Location = new System.Drawing.Point(734, 285);
            this.buttonExtraRatings.Name = "buttonExtraRatings";
            this.buttonExtraRatings.Size = new System.Drawing.Size(106, 23);
            this.buttonExtraRatings.TabIndex = 21;
            this.buttonExtraRatings.Text = "More Ratings";
            this.buttonExtraRatings.UseVisualStyleBackColor = true;
            // 
            // labelJustIMDB_ID
            // 
            this.labelJustIMDB_ID.AutoSize = true;
            this.labelJustIMDB_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelJustIMDB_ID.Location = new System.Drawing.Point(333, 311);
            this.labelJustIMDB_ID.Name = "labelJustIMDB_ID";
            this.labelJustIMDB_ID.Size = new System.Drawing.Size(64, 20);
            this.labelJustIMDB_ID.TabIndex = 22;
            this.labelJustIMDB_ID.Text = "imdbID:";
            // 
            // labelJustImdbRating
            // 
            this.labelJustImdbRating.AutoSize = true;
            this.labelJustImdbRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelJustImdbRating.Location = new System.Drawing.Point(333, 339);
            this.labelJustImdbRating.Name = "labelJustImdbRating";
            this.labelJustImdbRating.Size = new System.Drawing.Size(98, 20);
            this.labelJustImdbRating.TabIndex = 23;
            this.labelJustImdbRating.Text = "imdb Rating:";
            // 
            // labelJustImdbVotes
            // 
            this.labelJustImdbVotes.AutoSize = true;
            this.labelJustImdbVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelJustImdbVotes.Location = new System.Drawing.Point(333, 367);
            this.labelJustImdbVotes.Name = "labelJustImdbVotes";
            this.labelJustImdbVotes.Size = new System.Drawing.Size(93, 20);
            this.labelJustImdbVotes.TabIndex = 24;
            this.labelJustImdbVotes.Text = "imdb Votes:";
            // 
            // labelInfoImdbVotes
            // 
            this.labelInfoImdbVotes.AutoSize = true;
            this.labelInfoImdbVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelInfoImdbVotes.Location = new System.Drawing.Point(445, 367);
            this.labelInfoImdbVotes.Name = "labelInfoImdbVotes";
            this.labelInfoImdbVotes.Size = new System.Drawing.Size(55, 20);
            this.labelInfoImdbVotes.TabIndex = 27;
            this.labelInfoImdbVotes.Text = "votes..";
            // 
            // labelInfoImdbRating
            // 
            this.labelInfoImdbRating.AutoSize = true;
            this.labelInfoImdbRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelInfoImdbRating.Location = new System.Drawing.Point(445, 339);
            this.labelInfoImdbRating.Name = "labelInfoImdbRating";
            this.labelInfoImdbRating.Size = new System.Drawing.Size(95, 20);
            this.labelInfoImdbRating.TabIndex = 26;
            this.labelInfoImdbRating.Text = "imdb rating..";
            // 
            // labelInfoImdbID
            // 
            this.labelInfoImdbID.AutoSize = true;
            this.labelInfoImdbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelInfoImdbID.Location = new System.Drawing.Point(445, 311);
            this.labelInfoImdbID.Name = "labelInfoImdbID";
            this.labelInfoImdbID.Size = new System.Drawing.Size(34, 20);
            this.labelInfoImdbID.TabIndex = 25;
            this.labelInfoImdbID.Text = "ID..";
            // 
            // labelInfoWriter
            // 
            this.labelInfoWriter.AutoSize = true;
            this.labelInfoWriter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoWriter.Location = new System.Drawing.Point(553, 193);
            this.labelInfoWriter.Name = "labelInfoWriter";
            this.labelInfoWriter.Size = new System.Drawing.Size(57, 21);
            this.labelInfoWriter.TabIndex = 32;
            this.labelInfoWriter.Text = "writer..";
            // 
            // labelJustWriter
            // 
            this.labelJustWriter.AutoSize = true;
            this.labelJustWriter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJustWriter.Location = new System.Drawing.Point(445, 193);
            this.labelJustWriter.Name = "labelJustWriter";
            this.labelJustWriter.Size = new System.Drawing.Size(62, 21);
            this.labelJustWriter.TabIndex = 31;
            this.labelJustWriter.Text = "Writer:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Source,
            this.Value});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(546, 311);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 141);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Source
            // 
            this.Source.Text = "Source";
            this.Source.Width = 190;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 95;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelInfoPlot);
            this.panel2.Location = new System.Drawing.Point(49, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 165);
            this.panel2.TabIndex = 34;
            // 
            // linkLabelImdb
            // 
            this.linkLabelImdb.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabelImdb.AutoSize = true;
            this.linkLabelImdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.linkLabelImdb.Location = new System.Drawing.Point(642, 31);
            this.linkLabelImdb.Name = "linkLabelImdb";
            this.linkLabelImdb.Size = new System.Drawing.Size(63, 15);
            this.linkLabelImdb.TabIndex = 35;
            this.linkLabelImdb.TabStop = true;
            this.linkLabelImdb.Text = "imdb link..";
            this.linkLabelImdb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelImdb_LinkClicked);
            // 
            // labelJustImdbLink
            // 
            this.labelJustImdbLink.AutoSize = true;
            this.labelJustImdbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelJustImdbLink.Location = new System.Drawing.Point(554, 31);
            this.labelJustImdbLink.Name = "labelJustImdbLink";
            this.labelJustImdbLink.Size = new System.Drawing.Size(82, 16);
            this.labelJustImdbLink.TabIndex = 36;
            this.labelJustImdbLink.Text = "Link to imdb:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.labelJustRated.Location = new System.Drawing.Point(445, 237);
            this.labelJustRated.Name = "labelJustRated";
            this.labelJustRated.Size = new System.Drawing.Size(58, 21);
            this.labelJustRated.TabIndex = 39;
            this.labelJustRated.Text = "Rated:";
            // 
            // buttonSaveToWatchlist
            // 
            this.buttonSaveToWatchlist.Location = new System.Drawing.Point(750, 206);
            this.buttonSaveToWatchlist.Name = "buttonSaveToWatchlist";
            this.buttonSaveToWatchlist.Size = new System.Drawing.Size(90, 52);
            this.buttonSaveToWatchlist.TabIndex = 40;
            this.buttonSaveToWatchlist.Text = "Save To Watch List";
            this.buttonSaveToWatchlist.UseVisualStyleBackColor = true;
            // 
            // InfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.buttonSaveToWatchlist);
            this.Controls.Add(this.labelJustRated);
            this.Controls.Add(this.labelJustType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelJustImdbLink);
            this.Controls.Add(this.linkLabelImdb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelInfoWriter);
            this.Controls.Add(this.labelJustWriter);
            this.Controls.Add(this.labelInfoImdbVotes);
            this.Controls.Add(this.labelInfoImdbRating);
            this.Controls.Add(this.labelInfoImdbID);
            this.Controls.Add(this.labelJustImdbVotes);
            this.Controls.Add(this.labelJustImdbRating);
            this.Controls.Add(this.labelJustIMDB_ID);
            this.Controls.Add(this.buttonExtraRatings);
            this.Controls.Add(this.buttonExtraIMDBInfo);
            this.Controls.Add(this.labelJustPlot);
            this.Controls.Add(this.labelInfoProduction);
            this.Controls.Add(this.labelJustProduction);
            this.Controls.Add(this.labelInfoCountry);
            this.Controls.Add(this.labelJustCountry);
            this.Controls.Add(this.labelInfoRated);
            this.Controls.Add(this.labelInfoType);
            this.Controls.Add(this.labelInfoRuntime);
            this.Controls.Add(this.labelJustRuntime);
            this.Controls.Add(this.labelInforActors);
            this.Controls.Add(this.labelJustActors);
            this.Controls.Add(this.labelInfoGenre);
            this.Controls.Add(this.labelJustGenre);
            this.Controls.Add(this.labelInfoMetascore);
            this.Controls.Add(this.labelJustMetascore);
            this.Controls.Add(this.labelInfoYear);
            this.Controls.Add(this.labelJustYear);
            this.Controls.Add(this.labelInfoTitle);
            this.Name = "InfoUC";
            this.Size = new System.Drawing.Size(843, 456);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoTitle;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelJustYear;
        private System.Windows.Forms.Label labelInfoYear;
        private System.Windows.Forms.Label labelInfoMetascore;
        private System.Windows.Forms.Label labelJustMetascore;
        private System.Windows.Forms.Label labelInfoGenre;
        private System.Windows.Forms.Label labelJustGenre;
        private System.Windows.Forms.Label labelInforActors;
        private System.Windows.Forms.Label labelJustActors;
        private System.Windows.Forms.Label labelInfoRuntime;
        private System.Windows.Forms.Label labelJustRuntime;
        private System.Windows.Forms.Label labelInfoType;
        private System.Windows.Forms.Label labelInfoRated;
        private System.Windows.Forms.Label labelInfoCountry;
        private System.Windows.Forms.Label labelJustCountry;
        private System.Windows.Forms.Label labelInfoProduction;
        private System.Windows.Forms.Label labelJustProduction;
        private System.Windows.Forms.Label labelInfoPlot;
        private System.Windows.Forms.Label labelJustPlot;
        private System.Windows.Forms.Button buttonExtraIMDBInfo;
        private System.Windows.Forms.Button buttonExtraRatings;
        private System.Windows.Forms.Label labelJustIMDB_ID;
        private System.Windows.Forms.Label labelJustImdbRating;
        private System.Windows.Forms.Label labelJustImdbVotes;
        private System.Windows.Forms.Label labelInfoImdbVotes;
        private System.Windows.Forms.Label labelInfoImdbRating;
        private System.Windows.Forms.Label labelInfoImdbID;
        private System.Windows.Forms.Label labelInfoWriter;
        private System.Windows.Forms.Label labelJustWriter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelImdb;
        private System.Windows.Forms.Label labelJustImdbLink;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Source;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Label labelJustType;
        private System.Windows.Forms.Label labelJustRated;
        private System.Windows.Forms.Button buttonSaveToWatchlist;
    }
}
