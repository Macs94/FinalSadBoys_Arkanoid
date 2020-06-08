using System;
using System.Drawing.Text;
using System.Windows.Forms;
using SadArkanoid.Modelo;
using SadArkanoid.Properties;

namespace SadArkanoid
{
    public partial class UserCtrlMainMenu : UserControl
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        
        public UserCtrlMainMenu()
        {
            InitializeComponent();
        }

        private void UserCtrlMainMenu_Load(object sender, EventArgs e)
        {
            TitleCard.BackgroundImage = Resources.ArkanoidTitle2;
            TitleCard.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            if (checkFullscreen.Checked)
                GameData.fullScreen = true;
            else
                GameData.fullScreen = false;
            
            ((FormInterface)this.Parent).ChangeControl(new UserCtrlUser());
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}