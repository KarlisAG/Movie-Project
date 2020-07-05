namespace Project_Movie.Forms
{
    partial class AddToWL
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.textBoxRated = new System.Windows.Forms.TextBox();
            this.labelRated = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxImdbID = new System.Windows.Forms.TextBox();
            this.labelImdbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(70, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(106, 35);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = " ";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(106, 61);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 3;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(66, 64);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(106, 87);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 5;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(68, 90);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year:";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(106, 113);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxLength.TabIndex = 7;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(57, 116);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(43, 13);
            this.labelLength.TabIndex = 6;
            this.labelLength.Text = "Length:";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(255, 35);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(100, 20);
            this.textBoxRating.TabIndex = 9;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(212, 35);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(41, 13);
            this.labelRating.TabIndex = 8;
            this.labelRating.Text = "Rating:";
            // 
            // textBoxRated
            // 
            this.textBoxRated.Location = new System.Drawing.Point(255, 61);
            this.textBoxRated.Name = "textBoxRated";
            this.textBoxRated.Size = new System.Drawing.Size(100, 20);
            this.textBoxRated.TabIndex = 11;
            // 
            // labelRated
            // 
            this.labelRated.AutoSize = true;
            this.labelRated.Location = new System.Drawing.Point(214, 61);
            this.labelRated.Name = "labelRated";
            this.labelRated.Size = new System.Drawing.Size(39, 13);
            this.labelRated.TabIndex = 10;
            this.labelRated.Text = "Rated:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelInfo.Location = new System.Drawing.Point(70, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(156, 15);
            this.labelInfo.TabIndex = 12;
            this.labelInfo.Text = "Please fill the bottom fields!";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(178, 139);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(255, 87);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 15;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(214, 91);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 14;
            this.labelGenre.Text = "Genre";
            // 
            // textBoxImdbID
            // 
            this.textBoxImdbID.Location = new System.Drawing.Point(255, 115);
            this.textBoxImdbID.Name = "textBoxImdbID";
            this.textBoxImdbID.Size = new System.Drawing.Size(100, 20);
            this.textBoxImdbID.TabIndex = 17;
            // 
            // labelImdbID
            // 
            this.labelImdbID.AutoSize = true;
            this.labelImdbID.Location = new System.Drawing.Point(214, 119);
            this.labelImdbID.Name = "labelImdbID";
            this.labelImdbID.Size = new System.Drawing.Size(41, 13);
            this.labelImdbID.TabIndex = 16;
            this.labelImdbID.Text = "ImdbID";
            // 
            // AddToWL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 189);
            this.Controls.Add(this.textBoxImdbID);
            this.Controls.Add(this.labelImdbID);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxRated);
            this.Controls.Add(this.labelRated);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddToWL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToWL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TextBox textBoxRated;
        private System.Windows.Forms.Label labelRated;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxImdbID;
        private System.Windows.Forms.Label labelImdbID;
    }
}