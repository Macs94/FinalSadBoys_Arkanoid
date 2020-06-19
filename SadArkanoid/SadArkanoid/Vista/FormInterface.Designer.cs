using System.ComponentModel;

namespace SadArkanoid
{
    partial class FormInterface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userCtrlMainMenu1 = new SadArkanoid.UserCtrlMainMenu();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.userCtrlMainMenu1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 789);
            this.panel1.TabIndex = 0;
            // 
            // userCtrlMainMenu1
            // 
            this.userCtrlMainMenu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCtrlMainMenu1.BackColor = System.Drawing.Color.Black;
            this.userCtrlMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrlMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.userCtrlMainMenu1.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.userCtrlMainMenu1.Name = "userCtrlMainMenu1";
            this.userCtrlMainMenu1.Size = new System.Drawing.Size(973, 789);
            this.userCtrlMainMenu1.TabIndex = 0;
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 789);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FormInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sad Arkanoid";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private SadArkanoid.UserCtrlMainMenu userCtrlMainMenu1;

        #endregion
    }
}