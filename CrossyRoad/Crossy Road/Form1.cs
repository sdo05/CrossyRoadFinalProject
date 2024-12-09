using static System.Formats.Asn1.AsnWriter;
using System.Text;

namespace Crossy_Road
{
    public partial class Form1 : Form
    {
        bool moveLeft, moveRight, moveUp, moveDown, Gameover;
        bool shield = false;
        bool slow = false;
        int speed = 12;
        int score = 0;
        int round = 1;

        int Car1Speed = 5;
        int Car2Speed = 5;
        int Car3Speed = 5;

        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
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
            int randomNumber = r.Next(1, 2);
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Car")
                    {
                        int hit = 0;
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (shield == false)
                            {
                                moveTimer.Stop();
                                Gameover = true;
                                Score.Text = "Score: " + score;
                                Fail.Text = "You Just Got Ran Over!!!\nPress Enter To Play Again\nScore: " + score;
                                Fail.Visible = true;
                                Fail.BringToFront();
                            }
                            else if (shield == true)
                            {
                                if (hit % 2 == 0)
                                {
                                    shield = false;
                                }
                            }
                        }
                        if ((string)x.Tag == "Lane")
                        {
                            if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                            {
                                x.Visible = false;
                                score = score + 1;
                            }
                        }
                        if ((string)x.Tag == "Shield")
                        {
                            if (Player.Bounds.IntersectsWith(x.Bounds))
                            {
                                Shield.Visible = false;
                                shield = true;
                            }
                        }
                        if ((string)x.Tag == "SlowDown")
                        {
                            if (Player.Bounds.IntersectsWith(x.Bounds) && SlowDown.Visible == true)
                            {
                                SlowDown.Visible = false;
                                slow = true;
                                if (slow == true && SlowDown.Visible == true)
                                {
                                    Car1Speed = Car1Speed - 2;
                                    Car2Speed = Car2Speed - 2;
                                    Car3Speed = Car3Speed - 2;
                                }
                            }
                        }
                    }
                }
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
                if (x is PictureBox && Shield.Visible == true)
                {
                    Shield.Visible = false;
                    shield = false;
                }
                if (x is PictureBox && SlowDown.Visible == true)
                {
                    SlowDown.Visible = false;
                    slow = false;
                    Car1Speed = Car1Speed + 2;
                    Car2Speed = Car2Speed + 2;
                    Car3Speed = Car3Speed + 2;
                }
            }

            Player.Left = 705;
            Player.Top = 888;
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
