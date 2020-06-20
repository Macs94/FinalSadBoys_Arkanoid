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

        private void UserCtrlMainMenu_Load(object sender, EventArgs e)
        {
            
            
            TitleCard.BackgroundImage = Resources.ArkanoidTitle2;
            TitleCard.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.Font = new Font("Zorque", 20.25F);
            btnHighScore.Font = new Font("Zorque", 20.25F);
            btnExit.Font= new Font("Zorque", 20.25F);
            checkFullscreen.Font = new Font("Zorque", 9.45F);
            

        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            if (checkFullscreen.Checked)
                GameData.fullScreen = true;
            else
                GameData.fullScreen = false;

            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrlUser());
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            ((FormInterface)this.ParentForm).ChangeControl(new UserCtrTopTen());
        }
        
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserCtrlMainMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnPlay_Click_1(sender, e);
        }

       
    }
}