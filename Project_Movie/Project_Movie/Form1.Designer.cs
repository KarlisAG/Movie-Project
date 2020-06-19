namespace Project_Movie
{
    partial class Form1
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
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonWatchList = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 46);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Location = new System.Drawing.Point(925, 6);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(56, 34);
            this.pictureBoxExit.TabIndex = 3;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonUser);
            this.panel2.Controls.Add(this.buttonInfo);
            this.panel2.Controls.Add(this.buttonWatchList);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 456);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 67);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonWatchList
            // 
            this.buttonWatchList.Location = new System.Drawing.Point(0, 100);
            this.buttonWatchList.Name = "buttonWatchList";
            this.buttonWatchList.Size = new System.Drawing.Size(127, 67);
            this.buttonWatchList.TabIndex = 3;
            this.buttonWatchList.Text = "My Watch List";
            this.buttonWatchList.UseVisualStyleBackColor = true;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(0, 200);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(127, 67);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Movie Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(0, 300);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(127, 67);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.Text = "User Info";
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(127, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 456);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(150, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(843, 456);
            this.panel4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(993, 502);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonWatchList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

