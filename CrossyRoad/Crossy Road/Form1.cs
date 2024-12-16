using System.Media;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Crossy_Road
{
    public partial class Form1 : Form
    {
        bool moveLeft, moveRight, moveUp, moveDown, Gameover, GameStart,Playing;
        bool easy, normal, medium, hard, impossible;
        bool shield;
        bool slow;
        int speed = 12;
        int score = 0;
        int hit = 0;
        int cross = 0;
        int deaths = 0;

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
            if (moveLeft == true && Player.Left > 0)
            {
                Player.Left -= speed;
            }
            if (moveRight == true && Player.Left < 1440)
            {
                Player.Left += speed;
            }
            if (moveUp == true && Player.Top > 0)
            {
                Player.Top -= speed;
            }
            if (moveDown == true && Player.Top < 862)
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
                            if (shield == false)
                            {
                                moveTimer.Stop();
                                Gameover = true;
                                GameStart = false;
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
                        if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            if (hit >= 1)
                            {
                                shield = false;
                                Player.BackColor = Color.GreenYellow;
                            }
                            else
                            {
                                x.Visible = false;
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
                                Player.BackColor = Color.Blue;
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
                            }
                        }
                    }
                }
            }
            PlayerSpeed.Text = "Player Speed: " + speed.ToString();
            CarSpeed.Text = "Car Speed: " + Car1Speed.ToString();
            Score.Text = "Score: " + score;
            Round.Text = "Round " + round;
            if (round == 50 && Player.Top==10)
            {
                Fail.Text = "CONGRATULATIONS!!! You Managed To Not Get Ran Over\nDeaths: " + deaths + "\nDo You Want to Continue";
                Fail.BringToFront();
                Fail.Visible = true;
                Yes.Visible = true;
                No.Visible = true;
                GameStart = false;
            }
            if (round % 3 != 0)
            {
                Shield.Visible = false;
                SlowDown.Visible = false;
            }
            if (shield == true)
            {
                Shield.Visible = false;
            }
            if (GameStart == true)
            {
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
                    if (round <= 25)
                    {
                        Car1Speed++;
                        Car2Speed++;
                        Car3Speed++;
                    }
                    if (round > 25)
                    {
                        Car1Speed += 2;
                        Car2Speed += 2;
                        Car3Speed += 2;
                    }
                    if (Car1Speed > 70)
                    {
                        Car1Speed = 70;
                        Car2Speed = 70;
                        Car3Speed = 70;
                    }
                    Round.Text = "Round " + round;
                    if (round % 5 == 0)
                    {
                        speed += 3;
                    }
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
                        }
                    }
                }
            }
        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (GameStart == true)
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
                GameStart = true;
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
            if (Playing == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            slow = false;
            hit = 0;
            Player.Left = 711;
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
            Player.BackColor = Color.GreenYellow;
            shield = false;
            moveDown = false;
            moveUp = false;
            moveLeft = false;
            moveRight = false;
            Gameover = false;
            Fail.Visible = false;
            speed = 12; 
            if (easy == true)
            {
                Car1Speed = 3;
                Car2Speed = 3;
                Car3Speed = 3;
            }
            if (normal == true)
            {
                Car1Speed = 5;
                Car2Speed = 5;
                Car3Speed = 5;
            }
            if (medium == true)
            {
                Car1Speed = 7;
                Car2Speed = 7;
                Car3Speed = 7;
            }
            if (hard == true)
            {
                Car1Speed = 10;
                Car2Speed = 10;
                Car3Speed = 10;
            }
            if (impossible == true)
            {
                Car1Speed = 15;
                Car2Speed = 15;
                Car3Speed = 15;
            }
            if (GameStart == false)
            {
                score = 0;
                round = 1;
            }
            if (GameStart == true)
            {
                deaths++;
                score++;
                round++;
            }

            NewRound();
            moveTimer.Start();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            GameStart = false;
            Playing = false;
            deaths = 0;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            Easy.Visible = true;
            Normal.Visible = true;
            Medium.Visible = true;
            Hard.Visible = true;
            Impossible.Visible = true;
            label6.Visible = true;
            easy = false;
            normal = false;
            medium = false;
            hard = false;
            impossible = false;
            RestartGame();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Yes.Visible = false;
            No.Visible = false;
            Fail.Visible = false;
            Fail.SendToBack();
            GameStart = true;
            RestartGame();
        }

        private void No_Click(object sender, EventArgs e)
        {
            Yes.Visible = false;
            No.Visible = false;
            Fail.Visible = false;
            Fail.SendToBack();
            GameStart = false;
            Playing= false;
            deaths = 0;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            Easy.Visible = true;
            Normal.Visible = true;
            Medium.Visible = true;
            Hard.Visible = true;
            Impossible.Visible = true;
            label6.Visible = true;
            easy = false;
            normal = false;
            medium = false;
            hard = false;
            impossible = false;
            RestartGame();
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            GameStart = true;
            Playing = true;
            easy = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Easy.Visible = false;
            Normal.Visible = false;
            Medium.Visible = false;
            Hard.Visible = false;
            Impossible.Visible = false;
            label6.Visible = false;
            Car1Speed = 3;
            Car2Speed = 3;
            Car3Speed = 3;
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            GameStart = true;
            Playing = true;
            normal = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Easy.Visible = false;
            Normal.Visible = false;
            Medium.Visible = false;
            Hard.Visible = false;
            Impossible.Visible = false;
            label6.Visible = false;
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            GameStart = true;
            Playing = true;
            medium = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Easy.Visible = false;
            Normal.Visible = false;
            Medium.Visible = false;
            Hard.Visible = false;
            Impossible.Visible = false;
            label6.Visible = false;
            Car1Speed = 7;
            Car2Speed = 7;
            Car3Speed = 7;
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            GameStart = true;
            Playing = true;
            hard = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Easy.Visible = false;
            Normal.Visible = false;
            Medium.Visible = false;
            Hard.Visible = false;
            Impossible.Visible = false;
            label6.Visible = false;
            Car1Speed = 10;
            Car2Speed = 10;
            Car3Speed = 10;
        }

        private void Impossible_Click(object sender, EventArgs e)
        {
            GameStart = true;
            Playing = true;
            impossible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Easy.Visible = false;
            Normal.Visible = false;
            Medium.Visible = false;
            Hard.Visible = false;
            Impossible.Visible = false;
            label6.Visible = false;
            Car1Speed = 15;
            Car2Speed = 15;
            Car3Speed = 15;
        }
    }
}
