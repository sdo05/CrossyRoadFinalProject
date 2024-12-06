namespace Crossy_Road
{
    public partial class Form1 : Form
    {
        bool moveLeft, moveRight, moveUp, moveDown;
        int speed = 12;
        public Form1()
        {
            InitializeComponent();
        }
        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (moveLeft == true && Player.Left > 0) 
            {
                Player.Left -= speed;
            }
            if (moveRight == true && Player.Left < 1408)
            {
                Player.Left += speed;
            }
            if (moveUp == true && Player.Top > 0)
            {
                Player.Top -= speed;
            }
            if (moveDown == true && Player.Top < 889)
            {
                Player.Top += speed;
            }
        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.A)) {
                moveLeft = true;
            }
            if ((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.D)) {
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
        }
    }
}
