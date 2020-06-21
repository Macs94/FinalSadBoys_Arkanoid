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
            btnComenzar.Font = new Font("Zorque", 20.25F);
            btnReturn.Font = new Font("Zorque", 20.25F);
            txtUser.Font = new Font("Zorque", 26.25F);
            lblMessage.Font = new Font("Zorque", 9.25F );
            tableLayoutPanel1.SetRow(lblMessage,1);
            tableLayoutPanel1.SetColumn(lblMessage,2);
            tableLayoutPanel1.SetColumnSpan(lblMessage,2);
            lblMessage.Dock = DockStyle.Fill;

        }
        
        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Trim().Length == 0)
                    throw new EmptyUsernameException("No se permiten campos vacios");
                
                if (txtUsername.Text.Length > 25)
                    throw new LengthExceededException("Nombre demasiado largo");

                User u = new User();
                u.username = txtUsername.Text;
                if (!UserDAO.CheckUserNameExists(u.username)) 
                    UserDAO.NewUser(u.username);
                ((FormInterface) ParentForm).Hide();

                ((FormInterface) ParentForm).Hide();
                var form2 = new FormGame(u);
                form2.Closed += (s, args) => ((FormInterface) ParentForm).Close();
                form2.Show();
            }
            catch (EmptyUsernameException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (LengthExceededException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ((FormInterface)ParentForm).ChangeControl(new UserCtrlMainMenu());
        }
        
        private void UsernameKeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                BtnStart_Click(sender, e);
        }
    }
}