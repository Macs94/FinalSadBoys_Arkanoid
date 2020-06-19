using System;
using System.Drawing;
using System.Drawing.Text;
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
            this.Dock = DockStyle.Fill;
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
                    lblMessage.Text = "No se permimten campos vacios";
                }
                else
                {
                    User u = new User();
                    u.username = txtUsername.Text;
                    if (!UserDAO.checkUserNameExists(u.username))
                        UserDAO.newUser(u.username);
                    ((FormInterface)ParentForm).Hide();

                    ((FormInterface)ParentForm).Hide();
                    var form2 = new FormGame(u);
                    form2.Closed += (s, args) => ((FormInterface)ParentForm).Close(); 
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
            ((FormInterface)ParentForm).ChangeControl(new UserCtrlMainMenu());
        }
        
        private void txtUsernameKeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnComenzar_Click_1(sender, e);
        }
    }
}