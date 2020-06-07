using System;
using System.Windows.Forms;
using SadArkanoid.Modelo;
using SadArkanoid.Properties;

namespace SadArkanoid
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            TitleCard.BackgroundImage = Resources.ArkanoidTitle2;
            TitleCard.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (checkFullscreen.Checked)
                GameData.fullScreen = true;
            else
                GameData.fullScreen = false;
            
            ChooseUser ventana = new ChooseUser();
            ventana.Owner = this;
            Hide();
            ventana.ShowDialog();
            Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            HighScores ventana = new HighScores();
            ventana.Owner = this;
            Hide();
            ventana.ShowDialog();
            Close();
        }
    }
}