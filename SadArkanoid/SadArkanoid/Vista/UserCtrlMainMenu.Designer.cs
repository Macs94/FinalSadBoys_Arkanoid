using System.ComponentModel;

namespace SadArkanoid
{
    partial class UserCtrlMainMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.checkFullscreen = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.TitleCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.TitleCard)).BeginInit();
            this.SuspendLayout();
            // 
            // checkFullscreen
            // 
            this.checkFullscreen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkFullscreen.ForeColor = System.Drawing.Color.White;
            this.checkFullscreen.Location = new System.Drawing.Point(394, 320);
            this.checkFullscreen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkFullscreen.Name = "checkFullscreen";
            this.checkFullscreen.Size = new System.Drawing.Size(134, 46);
            this.checkFullscreen.TabIndex = 9;
            this.checkFullscreen.Text = "FullScreen";
            this.checkFullscreen.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(109, 352);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 57);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnHighScore
            // 
            this.btnHighScore.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnHighScore.FlatAppearance.BorderSize = 0;
            this.btnHighScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighScore.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnHighScore.ForeColor = System.Drawing.Color.White;
            this.btnHighScore.Location = new System.Drawing.Point(109, 293);
            this.btnHighScore.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(226, 57);
            this.btnHighScore.TabIndex = 7;
            this.btnHighScore.Text = "High Scores";
            this.btnHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHighScore.UseVisualStyleBackColor = true;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(109, 234);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(226, 57);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // TitleCard
            // 
            this.TitleCard.BackColor = System.Drawing.Color.Transparent;
            this.TitleCard.Location = new System.Drawing.Point(77, 58);
            this.TitleCard.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TitleCard.Name = "TitleCard";
            this.TitleCard.Size = new System.Drawing.Size(451, 129);
            this.TitleCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleCard.TabIndex = 5;
            this.TitleCard.TabStop = false;
            // 
            // UserCtrlMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.checkFullscreen);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.TitleCard);
            this.Name = "UserCtrlMainMenu";
            this.Size = new System.Drawing.Size(600, 500);
            this.Load += new System.EventHandler(this.UserCtrlMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize) (this.TitleCard)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox checkFullscreen;
        private System.Windows.Forms.PictureBox TitleCard;

        #endregion
    }
}