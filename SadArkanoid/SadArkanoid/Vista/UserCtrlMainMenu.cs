using System;
using System.Drawing;
using System.Windows.Forms;
using SadArkanoid.Modelo;
using SadArkanoid.Properties;
using System.Drawing.Text;

namespace SadArkanoid
{
    public partial class UserCtrlMainMenu : UserControl
    {
        
        public UserCtrlMainMenu()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        //MÉTODOS 
        /*
         * Método: void UserCtrlMainMenu_Load(object sender, EventArgs e)
         *
         * Función: ocurre antes de mostrar el user control.
         *
         * Descripción: Carga la imagen del título (TitleCard) y asigna la fuente personalizada
         * "zorque" a los 3 botones del menú principal.
         *
         * 
         */

        private void UserCtrlMainMenu_Load(object sender, EventArgs e)
        {
            
            
            TitleCard.BackgroundImage = Resources.ArkanoidTitle2;
            TitleCard.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.Font = new Font("Zorque", 20.25F);
            btnHighScore.Font = new Font("Zorque", 20.25F);
            btnExit.Font= new Font("Zorque", 20.25F);
            checkFullscreen.Font = new Font("Zorque", 9.45F);
            

        }
        /*
         * Método: void BtnPlay_Click(object sender, EventArgs e)
         *
         * Función: detecta si se ha hecho click en el botón Play.
         *
         * Descripción: modifica el valor de verdad de GameData.fullScreen dependiendo si el checkFullscreen esta
         * chequeado o no y cambia el user control a UserCtrlUser (para introducir usuario).
         * 
         */

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (checkFullscreen.Checked)
                GameData.fullScreen = true;
            else
                GameData.fullScreen = false;

            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrlUser());
        }
        /*
         * Método: void BtnHighScore_Click(object sender, EventArgs e)
         *
         * Función: detecta si se ha hecho click en el botón HighScore.
         *
         * Descripción: cambia el user control a UserCtrlTopTen (máximas puntuaciones).
         * 
         */

        private void BtnHighScore_Click(object sender, EventArgs e)
        {
            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrTopTen());
        }
        
        /*
         * Método: void BtnExit_Click(object sender, EventArgs e)
         *
         * Función: detecta si se ha hecho click en el botón Exit.
         *
         * Descripción: finaliza la aplicación.
         * 
         */
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
         * Método: void UserCtrlMainMenu_KeyPress(object sender, EventArgs e)
         *
         * Función: detecta pulsación de tecla.
         *
         * Descripción: si el usuario presiona la tecla Intro/Enter se llama al método BtnPlay_Click.
         * 
         */

        private void UserCtrlMainMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                BtnPlay_Click(sender, e);
        }

       
    }
}