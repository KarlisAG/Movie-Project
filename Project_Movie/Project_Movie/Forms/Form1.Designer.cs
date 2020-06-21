namespace Project_Movie
{
    partial class FormApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelJustProjectInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonWatchList = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSlider = new System.Windows.Forms.Button();
            this.watchListUC1 = new Project_Movie.WatchListUC();
            this.infoUC1 = new Project_Movie.InfoUC();
            this.searchUC1 = new Project_Movie.SearchUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.labelJustProjectInfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseMove);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(941, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 34);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelJustProjectInfo
            // 
            this.labelJustProjectInfo.AutoSize = true;
            this.labelJustProjectInfo.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelJustProjectInfo.Location = new System.Drawing.Point(199, 0);
            this.labelJustProjectInfo.Name = "labelJustProjectInfo";
            this.labelJustProjectInfo.Size = new System.Drawing.Size(656, 34);
            this.labelJustProjectInfo.TabIndex = 5;
            this.labelJustProjectInfo.Text = "Your Personal Movie Watch List Application";
            this.labelJustProjectInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseDown);
            this.labelJustProjectInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonUser);
            this.panel2.Controls.Add(this.buttonInfo);
            this.panel2.Controls.Add(this.buttonWatchList);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 466);
            this.panel2.TabIndex = 1;
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(0, 300);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(127, 67);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.Text = "User Info";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(0, 200);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(127, 67);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Movie Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonWatchList
            // 
            this.buttonWatchList.Location = new System.Drawing.Point(0, 100);
            this.buttonWatchList.Name = "buttonWatchList";
            this.buttonWatchList.Size = new System.Drawing.Size(127, 67);
            this.buttonWatchList.TabIndex = 3;
            this.buttonWatchList.Text = "My Watch List";
            this.buttonWatchList.UseVisualStyleBackColor = true;
            this.buttonWatchList.Click += new System.EventHandler(this.buttonWatchList_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 67);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSlider);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(127, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 466);
            this.panel3.TabIndex = 2;
            // 
            // buttonSlider
            // 
            this.buttonSlider.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSlider.ForeColor = System.Drawing.Color.White;
            this.buttonSlider.Location = new System.Drawing.Point(0, 0);
            this.buttonSlider.Name = "buttonSlider";
            this.buttonSlider.Size = new System.Drawing.Size(10, 67);
            this.buttonSlider.TabIndex = 0;
            this.buttonSlider.UseVisualStyleBackColor = false;
            this.buttonSlider.Visible = false;
            // 
            // watchListUC1
            // 
            this.watchListUC1.Dock = System.Windows.Forms.DockStyle.Left;
            this.watchListUC1.Location = new System.Drawing.Point(1851, 36);
            this.watchListUC1.Name = "watchListUC1";
            this.watchListUC1.Size = new System.Drawing.Size(857, 466);
            this.watchListUC1.TabIndex = 5;
            this.watchListUC1.Visible = false;
            // 
            // infoUC1
            // 
            this.infoUC1.BackColor = System.Drawing.Color.Cornsilk;
            this.infoUC1.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoUC1.Location = new System.Drawing.Point(994, 36);
            this.infoUC1.Name = "infoUC1";
            this.infoUC1.Size = new System.Drawing.Size(857, 466);
            this.infoUC1.TabIndex = 4;
            this.infoUC1.Visible = false;
            // 
            // searchUC1
            // 
            this.searchUC1.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchUC1.Location = new System.Drawing.Point(137, 36);
            this.searchUC1.Name = "searchUC1";
            this.searchUC1.Size = new System.Drawing.Size(857, 466);
            this.searchUC1.TabIndex = 3;
            this.searchUC1.Visible = false;
            // 
            // FormApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(993, 502);
            this.Controls.Add(this.watchListUC1);
            this.Controls.Add(this.infoUC1);
            this.Controls.Add(this.searchUC1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormApp_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonWatchList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSlider;
        private System.Windows.Forms.Label labelJustProjectInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private SearchUC searchUC1;
        private InfoUC infoUC1;
        private WatchListUC watchListUC1;
    }
}

