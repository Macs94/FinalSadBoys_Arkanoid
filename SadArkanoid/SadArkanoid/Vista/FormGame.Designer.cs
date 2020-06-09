using System.ComponentModel;

namespace SadArkanoid
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.txtTime = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.secondsTimer = new System.Windows.Forms.Timer(this.components);
            this.controlsInfo = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.GameOverScreen = new System.Windows.Forms.PictureBox();
            this.VictoryScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.controlsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.GameOverScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.VictoryScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Location = new System.Drawing.Point(460, 782);
            this.player.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(191, 52);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Location = new System.Drawing.Point(522, 675);
            this.ball.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(42, 46);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(-70, -758);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(633, -752);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(251, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(173, -1568);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(251, 58);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(283, -618);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(251, 58);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Location = new System.Drawing.Point(167, -1431);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(251, 58);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Location = new System.Drawing.Point(-293, -2246);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(251, 58);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Location = new System.Drawing.Point(-69, -458);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(251, 58);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Location = new System.Drawing.Point(177, -1268);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(251, 58);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 1;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Location = new System.Drawing.Point(58, -2081);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(251, 58);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 1;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Location = new System.Drawing.Point(-402, -2896);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(251, 58);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 1;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Location = new System.Drawing.Point(633, -446);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(251, 58);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 1;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Location = new System.Drawing.Point(167, -1125);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(251, 58);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 1;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.Location = new System.Drawing.Point(410, -1935);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(251, 58);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 1;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.Location = new System.Drawing.Point(293, -2748);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(251, 58);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 1;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.Location = new System.Drawing.Point(-167, -3564);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(251, 58);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 1;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox23.Location = new System.Drawing.Point(1298, -475);
            this.pictureBox23.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(251, 58);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 1;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox24.Location = new System.Drawing.Point(1190, -1125);
            this.pictureBox24.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(251, 58);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 1;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.Location = new System.Drawing.Point(723, -1804);
            this.pictureBox25.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(251, 58);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 1;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox26.Location = new System.Drawing.Point(967, -2614);
            this.pictureBox26.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(251, 58);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 1;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox27.Location = new System.Drawing.Point(850, -3429);
            this.pictureBox27.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(251, 58);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 1;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox28.Location = new System.Drawing.Point(390, -4242);
            this.pictureBox28.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(251, 58);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 1;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox30.Location = new System.Drawing.Point(1298, -606);
            this.pictureBox30.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(251, 58);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 1;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox31.Location = new System.Drawing.Point(1190, -1256);
            this.pictureBox31.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(251, 58);
            this.pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox31.TabIndex = 1;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox32.Location = new System.Drawing.Point(723, -1935);
            this.pictureBox32.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(251, 58);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox32.TabIndex = 1;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox33.Location = new System.Drawing.Point(967, -2744);
            this.pictureBox33.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(251, 58);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox33.TabIndex = 1;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox34.Location = new System.Drawing.Point(850, -3558);
            this.pictureBox34.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(251, 58);
            this.pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox34.TabIndex = 1;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox35.Location = new System.Drawing.Point(390, -4371);
            this.pictureBox35.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(251, 58);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox35.TabIndex = 1;
            this.pictureBox35.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Transparent;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(371, 19);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(331, 64);
            this.txtTime.TabIndex = 0;
            this.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.Location = new System.Drawing.Point(3, 19);
            this.heart1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(57, 61);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 2;
            this.heart1.TabStop = false;
            this.heart1.Tag = "hp";
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.Location = new System.Drawing.Point(71, 19);
            this.heart2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(57, 61);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 2;
            this.heart2.TabStop = false;
            this.heart2.Tag = "hp";
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.Location = new System.Drawing.Point(138, 19);
            this.heart3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(57, 61);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 2;
            this.heart3.TabStop = false;
            this.heart3.Tag = "hp";
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(713, 19);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(431, 64);
            this.txtScore.TabIndex = 0;
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // secondsTimer
            // 
            this.secondsTimer.Interval = 1000;
            this.secondsTimer.Tick += new System.EventHandler(this.secondsTimerEvent);
            // 
            // controlsInfo
            // 
            this.controlsInfo.BackColor = System.Drawing.Color.Transparent;
            this.controlsInfo.Location = new System.Drawing.Point(163, 329);
            this.controlsInfo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.controlsInfo.Name = "controlsInfo";
            this.controlsInfo.Size = new System.Drawing.Size(791, 375);
            this.controlsInfo.TabIndex = 3;
            this.controlsInfo.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.Location = new System.Drawing.Point(3, 86);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(364, 28);
            this.lblPlayer.TabIndex = 4;
            // 
            // GameOverScreen
            // 
            this.GameOverScreen.BackColor = System.Drawing.Color.Transparent;
            this.GameOverScreen.Location = new System.Drawing.Point(163, 259);
            this.GameOverScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameOverScreen.Name = "GameOverScreen";
            this.GameOverScreen.Size = new System.Drawing.Size(791, 425);
            this.GameOverScreen.TabIndex = 5;
            this.GameOverScreen.TabStop = false;
            this.GameOverScreen.Visible = false;
            // 
            // VictoryScreen
            // 
            this.VictoryScreen.BackColor = System.Drawing.Color.Transparent;
            this.VictoryScreen.Location = new System.Drawing.Point(160, 230);
            this.VictoryScreen.Name = "VictoryScreen";
            this.VictoryScreen.Size = new System.Drawing.Size(793, 405);
            this.VictoryScreen.TabIndex = 6;
            this.VictoryScreen.TabStop = false;
            this.VictoryScreen.Visible = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 1002);
            this.Controls.Add(this.VictoryScreen);
            this.Controls.Add(this.GameOverScreen);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.controlsInfo);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARKANOID";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize) (this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.controlsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.GameOverScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.VictoryScreen)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox controlsInfo;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer secondsTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtTime;

        #endregion

        private System.Windows.Forms.PictureBox GameOverScreen;
        private System.Windows.Forms.PictureBox VictoryScreen;
    }
}