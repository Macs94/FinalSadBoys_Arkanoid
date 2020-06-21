using System.ComponentModel;

namespace SadArkanoid
{
    partial class UserCtrTopTen
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

        private void InitializeComponent()
{
    this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
    this.btn_return = new System.Windows.Forms.Button();
    this.lblTopTen = new System.Windows.Forms.Label();
    this.tableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    // 
    // tableLayoutPanel1
    // 
    this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
    this.tableLayoutPanel1.ColumnCount = 4;
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
    this.tableLayoutPanel1.Controls.Add(this.btn_return, 0, 0);
    this.tableLayoutPanel1.Controls.Add(this.lblTopTen, 1, 0);
    this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
    this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
    this.tableLayoutPanel1.RowCount = 13;
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.008F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.004F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.362545F));
    this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 567);
    this.tableLayoutPanel1.TabIndex = 0;
    // 
    // btn_return
    // 
    this.btn_return.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.btn_return.FlatAppearance.BorderSize = 0;
    this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
    this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
    this.btn_return.ForeColor = System.Drawing.Color.White;
    this.btn_return.Location = new System.Drawing.Point(2, 3);
    this.btn_return.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
    this.btn_return.Name = "btn_return";
    this.btn_return.Size = new System.Drawing.Size(110, 47);
    this.btn_return.TabIndex = 0;
    this.btn_return.Text = "Return";
    this.btn_return.UseVisualStyleBackColor = true;
    this.btn_return.Click += new System.EventHandler(this.BtnReturn_Click);
    // 
    // lblTopTen
    // 
    this.lblTopTen.BackColor = System.Drawing.Color.Black;
    this.tableLayoutPanel1.SetColumnSpan(this.lblTopTen, 2);
    this.lblTopTen.Dock = System.Windows.Forms.DockStyle.Fill;
    this.lblTopTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.lblTopTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
    this.lblTopTen.ForeColor = System.Drawing.Color.White;
    this.lblTopTen.Location = new System.Drawing.Point(184, 0);
    this.lblTopTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
    this.lblTopTen.Name = "lblTopTen";
    this.lblTopTen.Size = new System.Drawing.Size(360, 113);
    this.lblTopTen.TabIndex = 1;
    this.lblTopTen.Text = "Top 10 ";
    this.lblTopTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // UserCtrTopTen
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.Controls.Add(this.tableLayoutPanel1);
    this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
    this.Name = "UserCtrTopTen";
    this.Size = new System.Drawing.Size(729, 567);
    this.Load += new System.EventHandler(this.UserCtrTopTen_Load);
    this.tableLayoutPanel1.ResumeLayout(false);
    this.ResumeLayout(false);
}

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion

        private System.Windows.Forms.Label lblTopTen;
    }
}