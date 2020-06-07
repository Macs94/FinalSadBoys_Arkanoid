using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using SadArkanoid.Controladores;
using SadArkanoid.Modelo;
using SadArkanoid.Properties;

namespace SadArkanoid
{
    public partial class FormGame : Form
    {
        private bool goLeft;
        private bool goRight;

        private int score;
        private int ballX;
        private int ballY;
        private int playerSpeed;
        private int hp;
        private int time;
        private int blockCount;

        private Random rnd = new Random();

        private CustomPictureBox[,] cpb;
        
        private PrivateFontCollection pfc = new PrivateFontCollection();

        private User playahata;
        
        public FormGame(User supremePlayaHata)
        {
            InitializeComponent();
            playahata = supremePlayaHata;
            DoubleBuffered = true;
        }
        
        private void FormGame_Load(object sender, EventArgs e)
        {
            //GameData.fullScreen = true;
            
            pfc.AddFontFile("../../Resources/zorque.ttf");
            
            if (GameData.fullScreen)
                WindowState = FormWindowState.Maximized;
            
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            gameSetUp();

            lblPlayer.Text = playahata.username;
            lblPlayer.Font = new Font(pfc.Families[0],12);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.BackColor = Color.Transparent;

            BackgroundImage = Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;

            player.Image = Resources.Player;
            player.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Image = Resources.Ball;
            ball.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        private void gameSetUp()
        {
            GameData.gameOver = false;
            GameData.gameStart = false;
            GameData.success = false;
            
            hp = 3;
            score = 0;
            playerSpeed = 12;
            txtScore.Text = "SCORE: " + 0;
            txtTime.Text = "TIME: " + 0;
            time = 0;
            blockCount = 0;
            player.Top = Height - 80;
            player.Left = Width / 2 - 50;

            gameTimer.Interval = 20;
            secondsTimer.Interval = 1000;
            
            ballReset();

            txtTime.Top = 10;
            txtTime.Left = Width / 2 - 80;
            txtTime.Font = new Font(pfc.Families[0], 22);

            txtScore.Top = 10;
            txtScore.Left = Width - txtScore.Width;
            txtScore.Font = new Font(pfc.Families[0], 22);

            heart1.BackgroundImage = Resources.Heart;
            heart1.BackgroundImageLayout = ImageLayout.Stretch;
            heart2.BackgroundImage = Resources.Heart; 
            heart2.BackgroundImageLayout = ImageLayout.Stretch;
            heart3.BackgroundImage = Resources.Heart; 
            heart3.BackgroundImageLayout = ImageLayout.Stretch;

            controlsInfo.BackgroundImage = Resources.Controls;
            controlsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            controlsInfo.Height = (int) (Height * 0.3);
            controlsInfo.Width = (int) (Width * 0.7);
            controlsInfo.Top = (int) (Height * 0.45);
            controlsInfo.Left = (int) (Width * 0.15);
            
            loadTiles1();
            
            gameTimer.Start();
        }
        
        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (GameData.gameStart)
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
                    GameData.gameStart = false;
                    switch (hp)
                    {
                        case 2:
                            heart3.Visible = false;
                            break;
                        case 1:
                            heart2.Visible = false;
                            break;
                        case 0:
                            heart1.Visible = false;
                            GameData.gameOver = true;
                            break;
                    }
                    
                    ballReset();
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
                        var customBlock = (CustomPictureBox) block;
                        if (ball.Bounds.IntersectsWith(customBlock.Bounds))
                        {
                            if (customBlock.golpes == 2)
                            {
                                ballY = -ballY;
                                customBlock.golpes--;
                                customBlock.BackgroundImage = Resources.Tile_silver_damaged;
                            }
                            else 
                            {
                                ballY = -ballY;
                                score += customBlock.addedScore;
                                Controls.Remove(customBlock);
                                blockCount--;
                            }
                        }
                    }
                }

                if (blockCount == 0)
                {
                    GameData.gameOver = true;
                    GameData.success = true;
                }

                gameIsOver();
            }
            else
            {
                if (goLeft && player.Left > 0)
                {
                    player.Left -= playerSpeed;
                    ball.Left -= playerSpeed;
                }

                if (goRight && player.Right < Width)
                {
                    player.Left += playerSpeed;
                    ball.Left += playerSpeed;
                }
            }
        }
        
        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                GameData.gameStart = true;
                secondsTimer.Start();
                controlsInfo.Visible = false;
            }

            if (e.KeyCode == Keys.Left)
                goLeft = true;

            if (e.KeyCode == Keys.Right)
                goRight = true;

            if (e.KeyCode == Keys.Escape)
            {
                MainMenu ventana = new MainMenu();
                ventana.Owner = this;
                Hide();
                ventana.ShowDialog();
                Close();
            }
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
            ball.Top = player.Top - 25;
            ball.Left = player.Left + 45;
            ballX = 5;
            ballY = -5;
        }
        
        private void gameIsOver()
        {
            if (GameData.gameOver)
            {
                gameTimer.Stop();
                secondsTimer.Stop();
                //playahata.score = score;
                //UserDAO.updateScore(playahata.username,playahata.score);
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
                            cpb[i, j].BackgroundImage = Resources.Tile_silver;
                            cpb[i, j].addedScore = 50;
                            break;
                        case 1:
                            cpb[i, j].BackgroundImage = Resources.Tile_red;
                            cpb[i, j].addedScore = 90;
                            break;
                        case 2:
                            cpb[i, j].BackgroundImage = Resources.Tile_yellow1;
                            cpb[i, j].addedScore = 120;
                            break;
                        case 3:
                            cpb[i, j].BackgroundImage = Resources.Tile_blue;
                            cpb[i, j].addedScore = 100;
                            break;
                        case 4:
                            cpb[i, j].BackgroundImage = Resources.Tile_violet;
                            cpb[i, j].addedScore = 110;
                            break;
                        case 5:
                            cpb[i, j].BackgroundImage = Resources.Tile_green;
                            cpb[i, j].addedScore = 80;
                            break;
                    }
                    Controls.Add(cpb[i, j]);
                }
            }
        }
    }
}