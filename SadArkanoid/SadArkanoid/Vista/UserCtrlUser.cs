using System;
using System.Windows.Forms;
using SadArkanoid.Controladores;

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
                    UserDAO.newUser(txtUsername.Text);
                    FormGame ventana = new FormGame();
                    ventana.Owner = ((FormInterface)Parent);
                    Hide();
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