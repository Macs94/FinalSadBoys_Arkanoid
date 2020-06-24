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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.userCtrlMainMenu1 = new SadArkanoid.UserCtrlMainMenu();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.userCtrlMainMenu1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(584, 389);
            this.mainPanel.TabIndex = 0;
            // 
            // userCtrlMainMenu1
            // 
            this.userCtrlMainMenu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userCtrlMainMenu1.BackColor = System.Drawing.Color.Black;
            this.userCtrlMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrlMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.userCtrlMainMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userCtrlMainMenu1.Name = "userCtrlMainMenu1";
            this.userCtrlMainMenu1.Size = new System.Drawing.Size(584, 389);
            this.userCtrlMainMenu1.TabIndex = 0;
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 389);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sad Arkanoid";
            this.Load += new System.EventHandler(this.FormInterface_Load);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel mainPanel;
        private SadArkanoid.UserCtrlMainMenu userCtrlMainMenu1;

        #endregion
    }
}