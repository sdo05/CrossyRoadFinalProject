using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Crossy_Road
{
    public partial class Form1 : Form
    {
        bool moveLeft, moveRight, moveUp, moveDown, Gameover;
        bool shield = false;
        bool slow = false;
        int speed = 12;
        int score = 0;
        int hit = 0;
        int cross = 0;

        int Car1Speed = 5;
        int Car2Speed = 5;
        int Car3Speed = 5;
        int round = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void moveTimerEvent(object sender, EventArgs e)
        {
            Score.Text = "Score " + score;
            if (moveLeft == true)
            {
                Player.Left -= speed;
            }
            if (moveRight == true)
            {
                Player.Left += speed;
            }
            if (moveUp == true)
            {
                Player.Top -= speed;
            }
            if (moveDown == true)
            {
                Player.Top += speed;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Car")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (shield == false) {
                                moveTimer.Stop();
                                Gameover = true;
                                Score.Text = "Score: " + score;
                                Fail.Text = "You Just Got Ran Over!!!\nPress Enter To Play Again\nScore: " + score;
                                Fail.Visible = true;
                                Fail.BringToFront();
                            }
                            if (shield == true)
                            {
                                hit++;
                            }
                        }
                    }
                    if ((string)x.Tag == "Lane")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false; //Crossing PictureBox in the middle gives 1 point
                            score = score + 1;
                        }
                    }
                    if ((string)x.Tag == "Cross")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (hit >= 1)
                            {
                                shield = false;
                            }
                        }
                    }
                    if ((string)x.Tag == "PowerUp" && (round % 3 == 0))
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true) // Choose between 2 powerups every 2 rounds
                        {
                            if ((string)x.Name == "Shield")
                            {
                                x.Visible = false;
                                SlowDown.Visible = false;    //Can survive one lane if hit
                                shield = true;
                            }
                            if ((string)x.Name == "SlowDown")
                            {
                                x.Visible = false;
                                Shield.Visible = false;    //Slows down cars for 1 round
                                slow = true;
                                cross++;

                                if (round <= 10)
                                {
                                    Car1Speed = Car1Speed - 5;
                                    Car2Speed = Car2Speed - 5;
                                    Car3Speed = Car3Speed - 5;
                                }
                                if (round > 10 && round <= 20)
                                {
                                    Car1Speed = Car1Speed - 10;
                                    Car2Speed = Car2Speed - 10;
                                    Car3Speed = Car3Speed - 10;
                                }
                                if (round > 20 && round <= 30)
                                {
                                    Car1Speed = Car1Speed - 15;
                                    Car2Speed = Car2Speed - 15;
                                    Car3Speed = Car3Speed - 15;
                                }
                                if (round > 30 && round <= 40)
                                {
                                    Car1Speed = Car1Speed - 20;
                                    Car2Speed = Car2Speed - 20;
                                    Car3Speed = Car3Speed - 20;
                                }
                                if (round > 40 && round <= 50)
                                {
                                    Car1Speed = Car1Speed - 25;
                                    Car2Speed = Car2Speed - 25;
                                    Car3Speed = Car3Speed - 25;
                                }
                                if (round > 50)
                                {
                                    Car1Speed = Car1Speed - 30;
                                    Car2Speed = Car2Speed - 30;
                                    Car3Speed = Car3Speed - 30;
                                }
                            }
                        }
                    }
                }
            }
            CarSpeed.Text = "Car Speed: " + Car1Speed.ToString();
            if (round % 3 != 0)
            {
                Shield.Visible = false;
                SlowDown.Visible = false;
            }
            Car1a.Left += Car1Speed;
            if (Car1a.Left >= 1409)
            {
                Car1a.Left = 0;
            }
            Car1b.Left += Car1Speed;
            if (Car1b.Left >= 1409)
            {
                Car1b.Left = 0;
            }
            Car1c.Left += Car1Speed;
            if (Car1c.Left >= 1409)
            {
                Car1c.Left = 0;
            }
            Car2a.Left -= Car2Speed;
            if (Car2a.Left <= 0)
            {
                Car2a.Left = 1409;
            }
            Car2b.Left -= Car2Speed;
            if (Car2b.Left <= 0)
            {
                Car2b.Left = 1409;
            }
            Car2c.Left -= Car2Speed;
            if (Car2c.Left <= 0)
            {
                Car2c.Left = 1409;
            }
            Car3a.Left += Car3Speed;
            if (Car3a.Left >= 1409)
            {
                Car3a.Left = 0;
            }
            Car3b.Left += Car3Speed;
            if (Car3b.Left >= 1409)
            {
                Car3b.Left = 0;
            }
            Car3c.Left += Car3Speed;
            if (Car3c.Left >= 1409)
            {
                Car3c.Left = 0;
            }
            if (Player.Top <= 10)
            {
                NewRound();
                round++;
                Car1Speed++;
                Car2Speed++;
                Car3Speed++;
                Round.Text = "Round " + round;
                if (round % 3 == 1)
                {
                    if (cross == 1)
                    {
                        cross = 0;
                        if (round <= 10)
                        {
                            Car1Speed = Car1Speed + 5;
                            Car2Speed = Car2Speed + 5;
                            Car3Speed = Car3Speed + 5;
                        }
                        if (round > 10 && round <= 20)
                        {
                            Car1Speed = Car1Speed + 10;
                            Car2Speed = Car2Speed + 10;
                            Car3Speed = Car3Speed + 10;
                        }
                        if (round > 20 && round <= 30)
                        {
                            Car1Speed = Car1Speed + 15;
                            Car2Speed = Car2Speed + 15;
                            Car3Speed = Car3Speed + 15;
                        }
                        if (round > 30 && round <= 40)
                        {
                            Car1Speed = Car1Speed + 20;
                            Car2Speed = Car2Speed + 20;
                            Car3Speed = Car3Speed + 20;
                        }
                        if (round > 40 && round <= 50)
                        {
                            Car1Speed = Car1Speed + 25;
                            Car2Speed = Car2Speed + 25;
                            Car3Speed = Car3Speed + 25;
                        }
                        if (round > 50)
                        {
                            Car1Speed = Car1Speed + 30;
                            Car2Speed = Car2Speed + 30;
                            Car3Speed = Car3Speed + 30;
                        }
                    }
                }
            }
        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.A))
            {
                moveLeft = true;
            }
            if ((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.D))
            {
                moveRight = true;
            }
            if ((e.KeyCode == Keys.Up) || (e.KeyCode == Keys.W))
            {
                moveUp = true;
            }
            if ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.S))
            {
                moveDown = true;
            }
        }
        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.A))
            {
                moveLeft = false;
            }
            if ((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.D))
            {
                moveRight = false;
            }
            if ((e.KeyCode == Keys.Up) || (e.KeyCode == Keys.W))
            {
                moveUp = false;
            }
            if ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.S))
            {
                moveDown = false;
            }

            if (e.KeyCode == Keys.Enter && Gameover == true)
            {
                RestartGame();
            }
        }
        private void NewRound()
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }
            shield = false;
            slow = false;
            hit = 0;
            Player.Left = 689;
            Player.Top = 862;
            Car1a.Left = 12;
            Car1b.Left = 612;
            Car1c.Left = 1212;
            Car2a.Left = 1398;
            Car2b.Left = 798;
            Car2c.Left = 198;
            Car3a.Left = 12;
            Car3b.Left = 612;
            Car3c.Left = 1212;
        }
        private void RestartGame()
        {
            moveDown = false;
            moveUp = false;
            moveLeft = false;
            moveRight = false;
            Gameover = false;
            Fail.Visible = false;
            Car1Speed = 5;
            Car2Speed = 5;
            Car3Speed = 5;

            score = 0;
            round = 1;

            Score.Text = "Score: " + score;
            Round.Text = "Round " + round;

            NewRound();
            moveTimer.Start();
        }
    }
}
