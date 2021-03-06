﻿namespace Project_Movie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelJustProjectInfo = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSlider = new System.Windows.Forms.Button();
            this.userInfo = new Project_Movie.UserInfo();
            this.watchListUC1 = new Project_Movie.WatchListUC();
            this.infoUC1 = new Project_Movie.InfoUC();
            this.searchUC1 = new Project_Movie.SearchUC();
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.buttonMovieInfo = new System.Windows.Forms.Button();
            this.buttonWatchList = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxLogout);
            this.panel1.Controls.Add(this.labelJustProjectInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseMove);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.buttonUserInfo);
            this.panel2.Controls.Add(this.buttonMovieInfo);
            this.panel2.Controls.Add(this.buttonWatchList);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 466);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.buttonSlider);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(127, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 466);
            this.panel3.TabIndex = 2;
            // 
            // buttonSlider
            // 
            this.buttonSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.buttonSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSlider.FlatAppearance.BorderSize = 0;
            this.buttonSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSlider.ForeColor = System.Drawing.Color.White;
            this.buttonSlider.Location = new System.Drawing.Point(0, 0);
            this.buttonSlider.Name = "buttonSlider";
            this.buttonSlider.Size = new System.Drawing.Size(10, 67);
            this.buttonSlider.TabIndex = 0;
            this.buttonSlider.UseVisualStyleBackColor = false;
            this.buttonSlider.Visible = false;
            // 
            // userInfo
            // 
            this.userInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.userInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfo.Location = new System.Drawing.Point(137, 36);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(856, 466);
            this.userInfo.TabIndex = 6;
            this.userInfo.Visible = false;
            // 
            // watchListUC1
            // 
            this.watchListUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.watchListUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchListUC1.Location = new System.Drawing.Point(137, 36);
            this.watchListUC1.Name = "watchListUC1";
            this.watchListUC1.Size = new System.Drawing.Size(856, 466);
            this.watchListUC1.TabIndex = 5;
            this.watchListUC1.Visible = false;
            // 
            // infoUC1
            // 
            this.infoUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.infoUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoUC1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.infoUC1.Location = new System.Drawing.Point(137, 36);
            this.infoUC1.Name = "infoUC1";
            this.infoUC1.Size = new System.Drawing.Size(856, 466);
            this.infoUC1.TabIndex = 4;
            this.infoUC1.Visible = false;
            // 
            // searchUC1
            // 
            this.searchUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.searchUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchUC1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.searchUC1.Location = new System.Drawing.Point(137, 36);
            this.searchUC1.Name = "searchUC1";
            this.searchUC1.Size = new System.Drawing.Size(856, 466);
            this.searchUC1.TabIndex = 3;
            this.searchUC1.Visible = false;
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.buttonUserInfo.FlatAppearance.BorderSize = 0;
            this.buttonUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonUserInfo.Image = global::Project_Movie.Properties.Resources.userInfo_real_;
            this.buttonUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserInfo.Location = new System.Drawing.Point(0, 300);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Size = new System.Drawing.Size(127, 67);
            this.buttonUserInfo.TabIndex = 3;
            this.buttonUserInfo.Text = "User Info";
            this.buttonUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUserInfo.UseVisualStyleBackColor = false;
            this.buttonUserInfo.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonMovieInfo
            // 
            this.buttonMovieInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.buttonMovieInfo.FlatAppearance.BorderSize = 0;
            this.buttonMovieInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovieInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonMovieInfo.Image = global::Project_Movie.Properties.Resources.movieInfo_real_;
            this.buttonMovieInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMovieInfo.Location = new System.Drawing.Point(0, 200);
            this.buttonMovieInfo.Name = "buttonMovieInfo";
            this.buttonMovieInfo.Size = new System.Drawing.Size(127, 67);
            this.buttonMovieInfo.TabIndex = 4;
            this.buttonMovieInfo.Text = "Movie Info";
            this.buttonMovieInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMovieInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMovieInfo.UseVisualStyleBackColor = false;
            this.buttonMovieInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonWatchList
            // 
            this.buttonWatchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.buttonWatchList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonWatchList.FlatAppearance.BorderSize = 0;
            this.buttonWatchList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonWatchList.ForeColor = System.Drawing.Color.Black;
            this.buttonWatchList.Image = global::Project_Movie.Properties.Resources.watchList_real_;
            this.buttonWatchList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWatchList.Location = new System.Drawing.Point(0, 100);
            this.buttonWatchList.Name = "buttonWatchList";
            this.buttonWatchList.Size = new System.Drawing.Size(127, 67);
            this.buttonWatchList.TabIndex = 3;
            this.buttonWatchList.Text = "My Watch List";
            this.buttonWatchList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonWatchList.UseVisualStyleBackColor = false;
            this.buttonWatchList.Click += new System.EventHandler(this.buttonWatchList_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Image = global::Project_Movie.Properties.Resources.Search_real_;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 67);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Movie.Properties.Resources.quit_real_;
            this.pictureBox1.Location = new System.Drawing.Point(941, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Image = global::Project_Movie.Properties.Resources.logout2_real_;
            this.pictureBoxLogout.Location = new System.Drawing.Point(885, 0);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(38, 36);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 7;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // FormApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(993, 502);
            this.Controls.Add(this.userInfo);
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
            this.Activated += new System.EventHandler(this.FormApp_Activated);
            this.Load += new System.EventHandler(this.FormApp_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormApp_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.Button buttonWatchList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSlider;
        private System.Windows.Forms.Label labelJustProjectInfo;
        private SearchUC searchUC1;
        private InfoUC infoUC1;
        private WatchListUC watchListUC1;
        public System.Windows.Forms.Button buttonMovieInfo;
        private UserInfo userInfo;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

