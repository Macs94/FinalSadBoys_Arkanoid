﻿using System;
using System.Windows.Forms;
using SadArkanoid.Controladores;

namespace SadArkanoid
{
    public partial class ChooseUser : Form
    {
        public ChooseUser()
        {
            InitializeComponent();
        }


        private void btnComenzar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Equals(""))
                {
                    MessageBox.Show("No se puede dejar campos vacios", "SadBoysArkanoid");
                }
                else
                {
                    UserDAO.newUser(txtUsername.Text);
                    FormGame ventana = new FormGame();
                    ventana.Owner = this;
                    Hide();
                    ventana.ShowDialog();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error o ya existe el jugador");
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainMenu ventana = new MainMenu();
            ventana.Owner = this;
            Hide();
            ventana.ShowDialog();
            Close();
        }
    }
}