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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize) (this.TitleCard)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkFullscreen
            // 
            this.checkFullscreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkFullscreen.ForeColor = System.Drawing.Color.White;
            this.checkFullscreen.Location = new System.Drawing.Point(566, 333);
            this.checkFullscreen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkFullscreen.Name = "checkFullscreen";
            this.checkFullscreen.Size = new System.Drawing.Size(128, 53);
            this.checkFullscreen.TabIndex = 9;
            this.checkFullscreen.Text = "FullScreen";
            this.checkFullscreen.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(218, 433);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(264, 66);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnHighScore
            // 
            this.btnHighScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHighScore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHighScore.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnHighScore.FlatAppearance.BorderSize = 0;
            this.btnHighScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnHighScore.ForeColor = System.Drawing.Color.White;
            this.btnHighScore.Location = new System.Drawing.Point(218, 327);
            this.btnHighScore.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(264, 66);
            this.btnHighScore.TabIndex = 7;
            this.btnHighScore.Text = "High Scores";
            this.btnHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHighScore.UseVisualStyleBackColor = true;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(218, 221);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(264, 66);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // TitleCard
            // 
            this.TitleCard.BackColor = System.Drawing.Color.Transparent;
            this.TitleCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleCard.Location = new System.Drawing.Point(142, 1);
            this.TitleCard.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TitleCard.Name = "TitleCard";
            this.TitleCard.Size = new System.Drawing.Size(416, 142);
            this.TitleCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleCard.TabIndex = 5;
            this.TitleCard.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TitleCard, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPlay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnHighScore, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkFullscreen, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 577);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // UserCtrlMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UserCtrlMainMenu";
            this.Size = new System.Drawing.Size(700, 577);
            this.Load += new System.EventHandler(this.UserCtrlMainMenu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserCtrlMainMenu_KeyPress);
            ((System.ComponentModel.ISupportInitialize) (this.TitleCard)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox checkFullscreen;
        private System.Windows.Forms.PictureBox TitleCard;

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}