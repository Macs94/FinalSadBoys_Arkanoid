using System;
using System.Windows.Forms;
using SadArkanoid.Modelo;
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

        private CustomPictureBox[,] cpb;
        
        public FormGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        
        private void FormGame_Load(object sender, EventArgs e)
        {
            if (GameData.fullScreen)
                WindowState = FormWindowState.Maximized;
            
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

            txtTime.Top = 10;
            txtTime.Left = Width / 2 - 100;

            txtScore.Top = 10;
            txtScore.Left = Width - txtScore.Width;
            
            loadTiles1();

            heart1.BackgroundImage = Resources.Heart;
            heart1.BackgroundImageLayout = ImageLayout.Stretch;
            heart2.BackgroundImage = Resources.Heart; 
            heart2.BackgroundImageLayout = ImageLayout.Stretch;
            heart3.BackgroundImage = Resources.Heart; 
            heart3.BackgroundImageLayout = ImageLayout.Stretch;
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
                if (block is CustomPictureBox && block.Tag == "blocks")
                {
                    var customBlock = (CustomPictureBox)block;
                    if (ball.Bounds.IntersectsWith(customBlock.Bounds))
                    {
                        if (customBlock.golpes == 2)
                        {
                            customBlock.golpes--;
                            customBlock.BackgroundImage = Resources.Tile___blinded_broken;
                        }
                        else
                        {
                            score += customBlock.addedScore;
                            ballY = -ballY;
                            Controls.Remove(customBlock);
                            blockCount--;
                        }
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

        private void loadTiles1()
        {
            int xAxis = 13;
            int yAxis = 6;

            int pbHeight = (int) (Height * 0.2) / yAxis;
            int pbWidth = (Width - xAxis) / xAxis;
            
            cpb = new CustomPictureBox[yAxis, xAxis];

            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    blockCount++;
                    cpb[i, j] = new CustomPictureBox();
                    cpb[i, j].Tag = "blocks";
                    cpb[i, j].golpes = 1;
                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight + 100;
                    switch (i)
                    {
                        case 0:
                            cpb[i, j].golpes = 2;
                            cpb[i, j].BackgroundImage = Resources.Tile___blinded;
                            cpb[i, j].addedScore = 50;
                            break;
                        case 1:
                            cpb[i, j].BackgroundImage = Resources.Tile___red;
                            cpb[i, j].addedScore = 90;
                            break;
                        case 2:
                            cpb[i, j].BackgroundImage = Resources.Tile___yellow;
                            cpb[i, j].addedScore = 120;
                            break;
                        case 3:
                            cpb[i, j].BackgroundImage = Resources.Tile___blue;
                            cpb[i, j].addedScore = 100;
                            break;
                        case 4:
                            cpb[i, j].BackgroundImage = Resources.Tile___pink;
                            cpb[i, j].addedScore = 110;
                            break;
                        case 5:
                            cpb[i, j].BackgroundImage = Resources.Tile___green;
                            cpb[i, j].addedScore = 80;
                            break;
                    }
                    Controls.Add(cpb[i, j]);
                }
            }
        }
    }
}