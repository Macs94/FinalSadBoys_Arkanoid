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
        //ATRIBUTOS GLOBALES
        
        //controles del juego
        private bool goLeft, goRight;
        private int ballX, ballY, playerSpeed;
        
        //estado del juego
        private int score,hp, time, blockCount;

        //atributos diversos
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
        
        //MÉTODOS
        
        /*
         * Método: void FormGame_Load(object sender, EventArgs e)
         * 
         * Función: ocurre antes de mostrar la form
         *
         * Descripción: Verifica el tamaño de pantalla escogido y llama el método
         * gameSetup() para preparar el juego.
         */
        private void FormGame_Load(object sender, EventArgs e)
        {
            pfc.AddFontFile("../../Resources/zorque.ttf");
            
            if (GameData.fullScreen)
                WindowState = FormWindowState.Maximized;
            
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            
            GameSetUp();
        }
        
        /*
         * Método: private void GameSetUp()
         * 
         * Función: preparar el juego
         *
         * Descripción: Reinicia los atributos de flujo (clase GameData) del juego
         * y los atributos de estado del juego.
         * Carga los aspectos gráficos del juego y configura su posición.
         * Configura y activa el reloj que gestiona las actualizaciones del juego.
         */
        private void GameSetUp()
        {
            //reiniciar atributos de flujo
            GameData.SoftReset();
            
            //reiniciar atributos de estado
            hp = 3;
            score = 0;
            playerSpeed = 12;
            time = 0;
            blockCount = 0;
            player.Top = Height - 70;
            player.Left = Width / 2 - 50;

            //aspectos gráficos
            BackgroundImage = Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;
            
            lblPlayer.Text = playahata.username;
            lblPlayer.Font = new Font(pfc.Families[0],12);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.BackColor = Color.Transparent;
            
            player.Image = Resources.Player;
            player.BackgroundImageLayout = ImageLayout.Stretch;

            BallReset();
            ball.Height = 15;
            ball.Width = 15;
            ball.Image = Resources.Ball;
            ball.BackgroundImageLayout = ImageLayout.Stretch;

            txtTime.Text = "TIME: " + 0;
            txtTime.Top = 10;
            txtTime.Left = Width / 2 - 80;
            txtTime.Font = new Font(pfc.Families[0], 22);

            txtScore.Text = "SCORE: " + 0;
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
            
            //cargar bloques
            LoadTiles();
            
            //configurar relojes
            gameTimer.Interval = 20;
            secondsTimer.Interval = 1000;
            
            //activar reloj de actualizaciones
            gameTimer.Start();
        }
        
        /*
         * Método: void GameTimerEvent(object sender, EventArgs e)
         * 
         * Función: gestiona las actualizaciones del juego
         * 
         * Descripción: Si el juego ha comenzado, actualiza la posición del jugador
         * y de la bola, maneja la destrucción de bloques y actualiza los atributos de
         * estado y flujo del juego cada 0.02 segundos.
         * Si el juego no ha comenzado, solo permite al jugador moverse manteniendo
         * la bola estática.
         */
        private void GameTimerEvent(object sender, EventArgs e)
        {
            //si el juego ha empezado, actualizar controles, bola, bloques y atributos 
            if (GameData.gameStart)
            {
                txtScore.Text = "SCORE: " + score;
                
                //movimiento del jugador
                if (goLeft && player.Left > 0)
                    player.Left -= playerSpeed;
                
                else if (goRight && player.Right + 20 < Width)
                    player.Left += playerSpeed;
                
                //movimiento de la bola
                ball.Left += ballX;
                ball.Top += ballY;

                //eventos relacionados con la bola
                switch (ball)
                {
                    case PictureBox b when b.Left < 0:
                        ballX = -ballX;
                        break;
                    
                    case PictureBox b when b.Right + 20 > Width:
                        ballX = -ballX;
                        break;
                    
                    case PictureBox b when b.Top < 0:
                        ballY = -ballY;
                        ball.Top += ballY;
                        break;
                    
                    case PictureBox b when b.Top > Height:
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
                        BallReset();
                        break;
                    
                    case PictureBox b when b.Bounds.IntersectsWith(player.Bounds):
                        ballY = -rnd.Next(5, 10);
                        if (ballX < 0)
                            ballX = -rnd.Next(5, 10);
                        else
                            ballX = rnd.Next(5, 10);
                        break;
                }

                //destrucción de bloque
                foreach (Control block in Controls)
                {
                    if (block is CustomPictureBox && block.Tag == "blocks")
                    {
                        var customBlock = (CustomPictureBox) block;
                        if (ball.Bounds.IntersectsWith(customBlock.Bounds))
                        {
                            ballY = -ballY;
                            
                            //bloque reforzado
                            if (customBlock.hits == 2)
                            {
                                customBlock.hits--;
                                customBlock.BackgroundImage = Resources.Tile_silver_damaged;
                            }
                            //bloque normal
                            else
                            {
                                score += customBlock.addedScore;
                                Controls.Remove(customBlock);
                                blockCount--;
                            }
                        }
                    }
                }

                //verificar si el jugdor ha ganado
                if (blockCount == 0)
                {
                    GameData.gameOver = true;
                    GameData.victory = true;
                }

                //verificar si el juego ha terminado
                GameIsOver();
            }
            //si el juego no ha empezado, solo mover jugador con bola estática
            else
            {
                if (goLeft && player.Left > 0)
                {
                    player.Left -= playerSpeed;
                    ball.Left -= playerSpeed;
                }

                else if (goRight && player.Right + 20 < Width)
                {
                    player.Left += playerSpeed;
                    ball.Left += playerSpeed;
                }
            }
        }
        
        /*
         * Método: void keyDown(object sender, KeyEventArgs e)
         * 
         * Función: detecta pulsación de tecla
         *
         * Descripción: Maneja los controles del juego. Modifica los atributos de
         * flujo que desencadenan los eventos del juego.
         */
        private void keyDown(object sender, KeyEventArgs e)
        {
            try
            { 
                switch (e.KeyCode){
                    
                //si el juego no ha comenzado, comenzar juego
                case Keys.Space:
                    if (!GameData.gameStart && !GameData.gameOver)
                    {
                        GameData.gameStart = true;
                        secondsTimer.Start();
                        controlsInfo.Visible = false;
                    }
                    break;

                //si el juego ha terminado, volver a jugar
                case Keys.Enter:
                    if (GameData.gameOver)
                    {
                        Controls.Clear();
                        InitializeComponent();
                        FormGame_Load(null, EventArgs.Empty);
                    }
                    break;
                
                //moverse a la izquierda
                case Keys.Left:
                    goLeft = true;
                    break;
                
                //moverse a la derecha
                case Keys.Right:
                    goRight = true;
                    break;
                
                //regresar al menú principal
                case Keys.Escape:
                    gameTimer.Stop(); 
                    secondsTimer.Stop();
                    this.Hide();
                    var form2 = new FormInterface();
                    form2.Closed += (s, args) => this.Close(); 
                    form2.Show();
                    break;
                default:
                    throw new WrongKeyException("Presione las teclas indicadas");
              } 
            }
            catch (WrongKeyException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         * Método: private void keyUp(object sender, KeyEventArgs e)
         * 
         * Función: detecta liberación de tecla
         * 
         * Descripción: Ayuda a manejar los controles del juego. Cancela el
         * movimiento del jugador al liberar tecla.
         */
        private void keyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = false;
                    break;
                
                case Keys.Right:
                    goRight = false;
                    break;
            }
        }

        //reiniciar bola 
        private void BallReset()
        {
            ball.Top = player.Top - 15;
            ball.Left = player.Left + 50;
            ballX = 5;
            ballY = -5;
        }
        
        /*
         * Método: private void GameIsOver()
         * 
         * Función: finalizar juego
         * 
         * Descripción: Verifica si el juego ha terminado, ya sea con una victoria
         * o con una derrota. Si el juego ha terminado, guarda la puntuación final
         * del jugador y detiene el reloj de actualizaciones del juego.
         */
        private void GameIsOver()
        {
            if (GameData.gameOver)
            {
                GameData.gameStart = false;
                //el jugador ha ganado
                if (GameData.victory)
                {
                    /*Aplicar multiplier basado en el tiempo que tomo para completar el juego y las vidas restantes
                    del jugador.*/
                    score += (score * 5 / time) * hp;
                    
                    
                    VictoryScreen.BackgroundImage = Resources.VictoryImg;
                    VictoryScreen.BackgroundImageLayout = ImageLayout.Stretch;
                    VictoryScreen.Height = (int) (Height * 0.65);
                    VictoryScreen.Width = (int) (Width * 0.80);
                    VictoryScreen.Top = (int) (Height * 0.20);
                    VictoryScreen.Left = (int) (Width * 0.08);
                    VictoryScreen.Show();
                }
                //el jugador ha perdido
                else
                {
                    GameOverScreen.BackgroundImage = Resources.GameOverImg;
                    GameOverScreen.BackgroundImageLayout = ImageLayout.Stretch;
                    GameOverScreen.Height = (int) (Height * 0.5);
                    GameOverScreen.Width = (int) (Width * 0.8);
                    GameOverScreen.Top = (int) (Height * 0.25);
                    GameOverScreen.Left = (int) (Width * 0.08);
                    GameOverScreen.Show();
                }
                
                //detener relojes
                secondsTimer.Stop();
                gameTimer.Stop();
                
                //guardar puntuación
                Score s = new Score(score, playahata.username);
                ScoreDAO.AddScore(s);
                
            }
        }
        
        //temporizador en segundos
        private void SecondsTimerEvent(object sender, EventArgs e)
        {
            time++;
            txtTime.Text = "TIME: " + time;
        }

        /*
         * Método: private void LoadTiles()
         * 
         * Función: carga los bloques del juego
         * 
         * Descripción: Crea los bloques del juego usando la clase customPictureBox.
         * Agrega un color, resistencia y valor a cada bloque.
         */
        private void LoadTiles()
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
                    cpb[i, j] = new CustomPictureBox
                    {
                        Tag = "blocks",
                        hits = 1,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Height = pbHeight,
                        Width = pbWidth,
                        Left = j * pbWidth,
                        Top = i * pbHeight + 70
                    };
                    switch (i)
                    {
                        case 0:
                            cpb[i, j].hits = 2;
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