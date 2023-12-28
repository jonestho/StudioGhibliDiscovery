namespace StudioGhibliDiscovery.User_Controls
{
    partial class UCFilm
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
            this.backButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filmName = new ZBobb.AlphaBlendTextBox();
            this.directorName = new ZBobb.AlphaBlendTextBox();
            this.rtScore = new ZBobb.AlphaBlendTextBox();
            this.movieLen = new ZBobb.AlphaBlendTextBox();
            this.filmDesc = new ZBobb.AlphaBlendTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.Font = new System.Drawing.Font("Javanese Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(10, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 72);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Black;
            this.homeButton.Font = new System.Drawing.Font("Javanese Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeButton.Location = new System.Drawing.Point(166, 10);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(156, 72);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(621, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 109);
            this.label2.TabIndex = 6;
            this.label2.Text = "Film Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 332);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // filmName
            // 
            this.filmName.BackAlpha = 0;
            this.filmName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filmName.Location = new System.Drawing.Point(295, 121);
            this.filmName.Multiline = true;
            this.filmName.Name = "filmName";
            this.filmName.ReadOnly = true;
            this.filmName.Size = new System.Drawing.Size(746, 67);
            this.filmName.TabIndex = 12;
            this.filmName.Text = "Name: ";
            this.filmName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filmName_MouseClick);
            // 
            // directorName
            // 
            this.directorName.BackAlpha = 0;
            this.directorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.directorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directorName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.directorName.Location = new System.Drawing.Point(295, 267);
            this.directorName.Multiline = true;
            this.directorName.Name = "directorName";
            this.directorName.ReadOnly = true;
            this.directorName.Size = new System.Drawing.Size(746, 67);
            this.directorName.TabIndex = 13;
            this.directorName.Text = "Director: ";
            // 
            // rtScore
            // 
            this.rtScore.BackAlpha = 0;
            this.rtScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtScore.Location = new System.Drawing.Point(295, 194);
            this.rtScore.Multiline = true;
            this.rtScore.Name = "rtScore";
            this.rtScore.ReadOnly = true;
            this.rtScore.Size = new System.Drawing.Size(746, 67);
            this.rtScore.TabIndex = 14;
            this.rtScore.Text = "Rotten Tomatoes Score: ";
            // 
            // movieLen
            // 
            this.movieLen.BackAlpha = 0;
            this.movieLen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieLen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieLen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieLen.Location = new System.Drawing.Point(295, 340);
            this.movieLen.Multiline = true;
            this.movieLen.Name = "movieLen";
            this.movieLen.ReadOnly = true;
            this.movieLen.Size = new System.Drawing.Size(746, 67);
            this.movieLen.TabIndex = 15;
            this.movieLen.Text = "Running Time: ";
            // 
            // filmDesc
            // 
            this.filmDesc.BackAlpha = 0;
            this.filmDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filmDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmDesc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filmDesc.Location = new System.Drawing.Point(34, 427);
            this.filmDesc.Multiline = true;
            this.filmDesc.Name = "filmDesc";
            this.filmDesc.ReadOnly = true;
            this.filmDesc.Size = new System.Drawing.Size(942, 327);
            this.filmDesc.TabIndex = 16;
            // 
            // UCFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudioGhibliDiscovery.Properties.Resources.Background;
            this.Controls.Add(this.filmDesc);
            this.Controls.Add(this.movieLen);
            this.Controls.Add(this.rtScore);
            this.Controls.Add(this.directorName);
            this.Controls.Add(this.filmName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Name = "UCFilm";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ZBobb.AlphaBlendTextBox filmName;
        private ZBobb.AlphaBlendTextBox directorName;
        private ZBobb.AlphaBlendTextBox rtScore;
        private ZBobb.AlphaBlendTextBox movieLen;
        private ZBobb.AlphaBlendTextBox filmDesc;
    }
}
