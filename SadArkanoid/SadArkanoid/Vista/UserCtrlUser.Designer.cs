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
            this.txtUser = new System.Windows.Forms.Label();
            this.TitleCard = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.TitleCard)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Maroon;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(149, 228);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(382, 38);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsernameKeyDown);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(98, 330);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(181, 99);
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
            this.btnComenzar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnComenzar.ForeColor = System.Drawing.Color.White;
            this.btnComenzar.Location = new System.Drawing.Point(406, 336);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(181, 89);
            this.btnComenzar.TabIndex = 5;
            this.btnComenzar.Text = "Begin Arkanoid";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click_1);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(149, 150);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(383, 77);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "Username";
            this.txtUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleCard
            // 
            this.TitleCard.BackColor = System.Drawing.Color.Transparent;
            this.TitleCard.Location = new System.Drawing.Point(149, 18);
            this.TitleCard.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TitleCard.Name = "TitleCard";
            this.TitleCard.Size = new System.Drawing.Size(383, 103);
            this.TitleCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleCard.TabIndex = 8;
            this.TitleCard.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(210, 273);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(248, 32);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserCtrlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.TitleCard);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.txtUser);
            this.Name = "UserCtrlUser";
            this.Size = new System.Drawing.Size(681, 532);
            this.Load += new System.EventHandler(this.UserCtrlUser_Load);
            ((System.ComponentModel.ISupportInitialize) (this.TitleCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox TitleCard;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.TextBox txtUsername;

        #endregion

        private System.Windows.Forms.Label lblMessage;
    }
}