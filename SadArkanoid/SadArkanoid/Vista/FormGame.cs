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
        private int hp;
        private int time;
        private int blockCount;

        private Random rnd = new Random();

        public FormGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        
        private void FormGame_Load(object sender, EventArgs e)
        {
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            gameSetUp();

            BackgroundImage = Resources.BackgroundSad;
            BackgroundImageLayout = ImageLayout.Stretch;

            player.Image = Resources.Player;
            player.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Image = Resources.Ball;
            ball.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        private void gameSetUp()
        {
            ballReset();
            playerReset();
            gameOver = false;
            hp = 3;
            score = 0;
            ballX = 5;
            ballY = -5;
            playerSpeed = 12;
            txtScore.Text = "SCORE: " + score;
            time = 0;
            blockCount = 0;

            foreach (Control staticObject in Controls)
            {
                if (staticObject is PictureBox && (string) staticObject.Tag == "blocks")
                {
                    staticObject.BackColor = Color.Gray;
                    blockCount++;
                }

                if (staticObject is PictureBox && (string) staticObject.Tag == "hp")
                {
                    staticObject.BackgroundImage = Resources.Heart;
                    staticObject.BackgroundImageLayout = ImageLayout.Stretch;
                } 
            }
        }
        
        private void gameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "SCORE: " + score;

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

            if (ball.Top > Height)
            {
                hp--;
                switch (hp)
                {
                    case 2:
                        Controls.Remove(heart3);
                        break;
                    case 1:
                        Controls.Remove(heart2);
                        break;
                    case 0:
                        Controls.Remove(heart1);
                        gameOver = true;
                        break;
                }
                gameTimer.Stop();
                ballReset();
                playerReset();
            }

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                ballY = -rnd.Next(5, 12);

                if (ballX < 0)
                    ballX = -rnd.Next(5, 12);
                else
                    ballX = rnd.Next(5, 12);
            }

            foreach (Control block in Controls)
            {
                if (block is PictureBox && (string) block.Tag == "blocks")
                {
                    if (ball.Bounds.IntersectsWith(block.Bounds))
                    {
                        score++;
                        ballY = -ballY;
                        Controls.Remove(block);
                        blockCount--;
                    }
                }
            }

            if (blockCount == 0)
                gameOver = true;
            
            gameIsOver();
        }
        
        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gameTimer.Start();
                secondsTimer.Start();
            }

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

        private void ballReset()
        {
            ball.Top = Height - 100;
            ball.Left = Width / 2;
            ballX = 5;
            ballY = -5;
        }

        private void playerReset()
        {
            player.Top = Height - 70;
            player.Left = Width / 2 - 50;
            playerSpeed = 12;
        }

        private void gameIsOver()
        {
            if (gameOver)
            {
                gameTimer.Stop();
                secondsTimer.Stop();
                MessageBox.Show("GAME OVER");
            }
        }
        
        private void secondsTimerEvent(object sender, EventArgs e)
        {
            time++;
            txtTime.Text = "TIME: " + time;
        }
    }
}