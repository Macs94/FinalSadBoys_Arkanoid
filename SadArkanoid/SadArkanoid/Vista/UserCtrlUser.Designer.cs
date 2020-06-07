using System.ComponentModel;

namespace SadArkanoid
{
    partial class UserCtrlUser
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Maroon;
            this.txtUsername.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(115, 208);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(329, 38);
            this.txtUsername.TabIndex = 7;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(56, 270);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(155, 77);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Back to Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.FlatAppearance.BorderSize = 0;
            this.btnComenzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnComenzar.ForeColor = System.Drawing.Color.White;
            this.btnComenzar.Location = new System.Drawing.Point(353, 270);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(175, 77);
            this.btnComenzar.TabIndex = 5;
            this.btnComenzar.Text = "Begin Arkanoid";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserCtrlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.label1);
            this.Name = "UserCtrlUser";
            this.Size = new System.Drawing.Size(584, 461);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;

        #endregion
    }
}