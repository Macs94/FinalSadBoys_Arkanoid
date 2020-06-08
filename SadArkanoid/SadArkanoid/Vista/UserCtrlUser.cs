using System;
using System.Windows.Forms;
using SadArkanoid.Controladores;
using SadArkanoid.Modelo;

namespace SadArkanoid
{
    public partial class UserCtrlUser : UserControl
    {
        public UserCtrlUser()
        {
            InitializeComponent();
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
                    FormGame ventana = new FormGame(u);
                    ((FormInterface)Parent).Hide();
                    ventana.ShowDialog();
                    ((FormInterface)Parent).Close();
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
    }
}