using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SadArkanoid.Controladores;
using SadArkanoid.Modelo;

namespace SadArkanoid
{
    public partial class UserCtrTopTen : UserControl
    {
        Label[] labels = new Label[20];
        public UserCtrTopTen()
        {
            InitializeComponent();
        }

        private void UserCtrTopTen_Load(object sender, EventArgs e)
        {
            loadLabels();
            this.Dock = DockStyle.Fill;
        }

        private void loadLabels()
        {
            int I = 0;
            List<Score> list = ScoreDAO.getTop10();
            for (int i = 0; i < list.Count; i++)
            {
                labels[i] = new Label();
                tableLayoutPanel1.Controls.Add(labels[i]);
                tableLayoutPanel1.SetRow(labels[i], i + 1);
                tableLayoutPanel1.SetColumn(labels[i], 1);
                labels[i].Text = list[i].username;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].Font = new Font("Consoles", 10);
                labels[i].Dock = DockStyle.Fill;
                I++;
            }
            for (int i = 0; i < list.Count; i++)
            {
                labels[I] = new Label();
                tableLayoutPanel1.Controls.Add(labels[I]);
                tableLayoutPanel1.SetRow(labels[I], i + 1);
                tableLayoutPanel1.SetColumn(labels[I], 2);
                labels[I].Text = list[i].score.ToString();
                labels[I].TextAlign = ContentAlignment.MiddleCenter;
                labels[I].Font = new Font("Consoles", 10);
                labels[I].Dock = DockStyle.Fill;
                I++;
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrlMainMenu());
        }
    }
}