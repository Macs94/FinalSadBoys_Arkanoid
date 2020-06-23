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
        //Métodos.
        /*
         * Método: void UserCtrlUser_Load(object sender, EventArgs e)
         *
         * Función: ocurre antes de que se muestre el user control
         *
         * Descripción: por buena práctica una vez se carga el user control el usuario puede comenzar a ingresar
         * su nombre inmediatamente con la función focus. Luego se cargan varios aspectos estéticos (fuente y
         * abracamiento del espacio de cada botón y label).
         */
        
        private void UserCtrlUser_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtUsername.Font = new Font("Zorque",20);
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
        /*
       * Método: void BtnStart_Click(object sender, EventArgs e)
       *
       * Función: detecta si ocurre un click en el boton Begin Arkanoid
       *
       * Descripción: El metodo verifica si se cumple con las restricciones de ingreso de usuario (número de caracteres
        * adecuado). Si se cumplen registra el usuario en la BD por medio de los controladores y despliega la ventana
        * de juego.
        * 
       * 
       * 
       */

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificación si el texto está vacio llama la excepcion de EmptyUsername
                if (txtUsername.Text.Trim().Length == 0)
                    throw new EmptyUsernameException("You must have a Username");
                //Verificación si el nombre es demasiado largo llama la excepción de LengthExceeded
                if (txtUsername.Text.Length > 25)
                    throw new LengthExceededException("Username length has to be 25 characters at most");

                User u = new User();
                u.username = txtUsername.Text;
                //Verificación si el nombre de usuario ya existe
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
        /*
         * Método: void BtnReturn_Click(object sender,EventArgs e)
         *
         * Función: detectar si ocurre un click en el botón Return to Menu.
         *
         * Descripción: cambia el user control de vuelta al MainMenu.
         */

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ((FormInterface)ParentForm).ChangeControl(new UserCtrlMainMenu());
        }
        /*
         * Método: void UsernameKeyDown(object sender, KeyPressEventArgs e)
         *
         * Función: detecta si se ha presionado una tecla.
         *
         * Descripción: si el usuario presiona la tecla Intro/Enter se llama al método BtnStart_CLick.
         */
        
        private void UsernameKeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                BtnStart_Click(sender, e);
        }
    }
}