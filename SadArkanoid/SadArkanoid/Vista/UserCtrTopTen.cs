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
        //ATRIBUTOS GLOBALES
        
        //Etiquetas que se ocuparan.
        Label[] labels = new Label[20];
        Label lblName = new Label();
        Label lblScore = new Label();
        Label lblException = new Label();

        public UserCtrTopTen()
        {
            InitializeComponent();
        }
        // METODOS.
        /*
         * 
         * Método: void UserCtrlTOpTen_Load(object sender, EventArgs e)
         *
         * Función: ocurre antes de mostrar el user control.
         *
         * Descripción: asigna a btn_return y a lblTopTen la fuente personalizada y carga los labels
         * de las máximas puntuaciones.
         * 
         */

        private void UserCtrTopTen_Load(object sender, EventArgs e)
        {
            btn_return.Font = new Font("Zorque",12);
            lblTopTen.Font = new Font("Zorque",22);
            LoadHeaderLabels();
            LoadLabels();
            Dock = DockStyle.Fill;
        }
        /*
         * Método: void LoadLabels()
         *
         * Función: carga las puntuaciones.
         *
         * Descripción: crea dos columnas de labels en orden decreciente (puntuación más alta primero), la primera
         * columna de nombres y la segunda de puntuaciones correspondientes. Se envía una excepción la lista está vacía.
         * 
         * 
         * 
         */

        private void LoadLabels()
        {
            try
            {
                int I = 0;
                List<Score> list = ScoreDAO.GetTop10();
                if(list.Count == 0)
                    throw new NoScoresSavedException("There are no scores at the moment");
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
            }catch(NoScoresSavedException ex)
            {
                tableLayoutPanel1.Controls.Add(lblException);
                tableLayoutPanel1.SetColumn(lblException,1);
                tableLayoutPanel1.SetRow(lblException,2);
                tableLayoutPanel1.SetColumnSpan(lblException, 2);
                lblException.Text = ex.Message;
                lblException.Font = new Font("Zorque",10);
                lblException.TextAlign = ContentAlignment.MiddleCenter;
                lblException.ForeColor = Color.White;
                lblException.Dock = DockStyle.Fill;
            }
        }

        /*
        * Método: void LoadLabels()
        *
        * Función: carga labels de cabecera.
        *
        * Descripción: crea dos columnas de labels en la cabecera para fines estéticos.
        * 
        * 
        */
        private void LoadHeaderLabels()
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
        }
        /*
         * Método: void BtnReturn_Click(object sender, EventArgs e)
         *
         * Función: detecta click en el botón Return.
         *
         * Descripción: hacer click carga el user control MainMenu.
         */

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrlMainMenu());
        }
    }
}