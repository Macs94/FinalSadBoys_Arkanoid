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
        private void ChooseUser_Load(object sender, EventArgs e)
        {
            //btnComenzar.Enabled = false;
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Equals(""))
                {
                    lblLogin.Text = "No se permimten campos vacios";
                }
                else if (UserDAO.checkUserName(txtUsername.Text) != "")
                {
                    User u = new User();
                    u.username = txtUsername.Text;
                    FormGame ventana = new FormGame(u);
                    ventana.Owner = this;
                    Hide();
                    ventana.ShowDialog();
                    Close();
                }
                else
                {
                    lblLogin.Text = "El usuario no existe, primero registrelo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtUsername.Text.Equals(""))
                {
                    lblLogin.Text = "No se permimten campos vacios";
                }
                else if (UserDAO.checkUserName(txtUsername.Text) != "")
                {
                    lblLogin.Text = "El usuario ya existe";
                }
                else
                {
                    User u = new User();
                    u.username = txtUsername.Text;
                    UserDAO.newUser(u.username); 
                    txtUsername.Clear();
                    lblLogin.Text = "El usuario registrado";
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