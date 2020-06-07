using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SadArkanoid.Controladores;
using SadArkanoid.Modelo;

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
                    User u = new User();
                    u.username = txtUsername.Text;
                    UserDAO.newUser(u.username);
                    FormGame ventana = new FormGame(u);
                    ventana.Owner = this;
                    Hide();
                    ventana.ShowDialog();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
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