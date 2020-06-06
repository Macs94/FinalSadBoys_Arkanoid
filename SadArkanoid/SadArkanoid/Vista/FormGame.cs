using System;
using System.Drawing;
using System.Windows.Forms;
using SadArkanoid.Properties;

namespace SadArkanoid
{
    public partial class FormGame : Form
    {
        private bool goLeft;
        private bool goRight;
        private bool gameOver;

        private int score;
        private int ballX;
        private int ballY;
        private int playerSpeed;

        private Random rnd = new Random();

        public FormGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            gameSetUp();
            
            Height = ClientSize.Height;
            Width = ClientSize.Width;
        }

        private void gameSetUp()
        {
            score = 0;
            ballX = 5;
            ballY = -5;
            playerSpeed = 12;
            txtScore.Text = "SCORE: " + score;

            foreach (Control ctrl in Controls)
            {
                if (ctrl is PictureBox && (string) ctrl.Tag == "blocks")
                    ctrl.BackColor = Color.Gray;

                if (ctrl is PictureBox && (string) ctrl.Tag == "hp")
                {
                    ctrl.BackgroundImage = Resources.Heart;
                    ctrl.BackgroundImageLayout = ImageLayout.Stretch;
                } 
            }
        }
        
        private void FormGame_Load(object sender, EventArgs e)
        {
            BackgroundImage = Resources.BackgroundSad;
            BackgroundImageLayout = ImageLayout.Stretch;

            player.Image = Resources.Player;
            player.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Image = Resources.Ball;
            ball.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft && player.Left > 0)
                player.Left -= playerSpeed;
            
            if (goRight && player.Right < Width)
                player.Left += playerSpeed;
            
            ball.Left += ballX;
            ball.Top += ballY;

            if (ball.Left < 0 || ball.Right > Width)
                ballX = -ballX;
            

            if (ball.Top < 0) 
                ballY = -ballY;
            
            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                ballY = -rnd.Next(5, 12);

                if (ballX < 0)
                    ballX = -rnd.Next(5, 12);
                else
                    ballX = rnd.Next(5, 12);
            }
        }
        
        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gameTimer.Start();

            if (e.KeyCode == Keys.Left)
                goLeft = true;

            if (e.KeyCode == Keys.Right)
                goRight = true;
            
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;

            if (e.KeyCode == Keys.Right)
                goRight = false;
        }
    }
}