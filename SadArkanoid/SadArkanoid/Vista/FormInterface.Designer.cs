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
            this.userCtrlMainMenu1 = new SadArkanoid.UserCtrlMainMenu();
            this.SuspendLayout();
            // 
            // userCtrlMainMenu1
            // 
            this.userCtrlMainMenu1.BackColor = System.Drawing.Color.Black;
            this.userCtrlMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrlMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.userCtrlMainMenu1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userCtrlMainMenu1.Name = "userCtrlMainMenu1";
            this.userCtrlMainMenu1.Size = new System.Drawing.Size(681, 473);
            this.userCtrlMainMenu1.TabIndex = 0;
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 473);
            this.Controls.Add(this.userCtrlMainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterface";
            this.ResumeLayout(false);
        }

        private SadArkanoid.UserCtrlMainMenu userCtrlMainMenu1;

        #endregion
    }
}