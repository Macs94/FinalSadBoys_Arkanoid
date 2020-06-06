using System.ComponentModel;

namespace SadArkanoid
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleCard = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.TitleCard)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleCard
            // 
            this.TitleCard.BackColor = System.Drawing.Color.Transparent;
            this.TitleCard.Location = new System.Drawing.Point(283, 25);
            this.TitleCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleCard.Name = "TitleCard";
            this.TitleCard.Size = new System.Drawing.Size(553, 198);
            this.TitleCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleCard.TabIndex = 0;
            this.TitleCard.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(433, 345);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(223, 86);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "1. Jugar";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnHighScore.FlatAppearance.BorderSize = 0;
            this.btnHighScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnHighScore.ForeColor = System.Drawing.Color.White;
            this.btnHighScore.Location = new System.Drawing.Point(433, 435);
            this.btnHighScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(223, 65);
            this.btnHighScore.TabIndex = 2;
            this.btnHighScore.Text = "2. Puntajes";
            this.btnHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHighScore.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(433, 504);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 61);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "3. Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 644);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.TitleCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid-Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize) (this.TitleCard)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox TitleCard;

        #endregion
    }
}