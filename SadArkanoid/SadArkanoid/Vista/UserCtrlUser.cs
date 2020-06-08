﻿using System;
using System.Windows.Forms;
using SadArkanoid.Controladores;
using SadArkanoid.Modelo;
using SadArkanoid.Properties;

namespace SadArkanoid
{
    public partial class UserCtrlUser : UserControl
    {
        public UserCtrlUser()
        {
            InitializeComponent();
        }
        
        private void UserCtrlUser_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            TitleCard.BackgroundImage = Resources.ArkanoidTitle2;
            TitleCard.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        private void btnComenzar_Click_1(object sender, EventArgs e)
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
                    if (!UserDAO.checkUserNameExists(u.username))
                        UserDAO.newUser(u.username);
                    ((FormInterface)Parent).Hide();

                    ((FormInterface)Parent).Hide();
                    var form2 = new FormGame(u);
                    form2.Closed += (s, args) => ((FormInterface)Parent).Close(); 
                    form2.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ((FormInterface)Parent).ChangeControl(new UserCtrlMainMenu());
        }


        private void txtUsernameKeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnComenzar_Click_1(sender, e);
        }
    }
}