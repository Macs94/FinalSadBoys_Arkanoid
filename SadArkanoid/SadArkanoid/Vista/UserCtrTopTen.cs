using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using SadArkanoid.Controladores;
using SadArkanoid.Modelo;
using SadArkanoid.Properties;

namespace SadArkanoid
{
    public partial class UserCtrTopTen : UserControl
    {
        Label[] labels = new Label[20];
        Label lblName = new Label();
        Label lblScore = new Label();

        public UserCtrTopTen()
        {
            InitializeComponent();
        }

        private void UserCtrTopTen_Load(object sender, EventArgs e)
        {
            LoadLabels();
            Dock = DockStyle.Fill;
        }

        private void LoadLabels()
        {
            tableLayoutPanel1.Controls.Add(lblName);
            tableLayoutPanel1.Controls.Add(lblScore);
            tableLayoutPanel1.SetRow(lblName, 1);
            tableLayoutPanel1.SetRow(lblScore, 1);
            tableLayoutPanel1.SetColumn(lblName, 1);
            tableLayoutPanel1.SetColumn(lblScore, 2);
            lblName.Text = "Name";
            lblScore.Text = "Score";
            lblName.Font = new Font("Zorque",16);
            lblScore.Font = new Font("Zorque",16);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            lblName.ForeColor = Color.White;
            lblScore.ForeColor = Color.White;
            lblName.Dock = DockStyle.Fill;
            lblScore.Dock = DockStyle.Fill;
            int I = 0;
            List<Score> list = ScoreDAO.getTop10();
            for (int i = 0; i < list.Count; i++)
            {
                labels[i] = new Label();
                tableLayoutPanel1.Controls.Add(labels[i]);
                tableLayoutPanel1.SetRow(labels[i], i + 2);
                tableLayoutPanel1.SetColumn(labels[i], 1);
                labels[i].Text = list[i].username;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].Font = new Font("Zorque", 12);
                labels[i].ForeColor = Color.White;
                labels[i].Dock = DockStyle.Fill;
                I++;
            }
            for (int i = 0; i < list.Count; i++)
            {
                labels[I] = new Label();
                tableLayoutPanel1.Controls.Add(labels[I]);
                tableLayoutPanel1.SetRow(labels[I], i + 2);
                tableLayoutPanel1.SetColumn(labels[I], 2);
                labels[I].Text = list[i].score.ToString();
                labels[I].TextAlign = ContentAlignment.MiddleCenter;
                labels[I].Font = new Font("Zorque", 12);
                labels[I].ForeColor = Color.White;
                labels[I].Dock = DockStyle.Fill;
                I++;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrlMainMenu());
        }
    }
}