using System;
using System.Windows.Forms;
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
            FormGame ventana = new FormGame();
            ventana.Owner = this;
            Hide();
            ventana.ShowDialog();
            Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}