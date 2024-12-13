namespace Crossy_Road
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Score = new Label();
            moveTimer = new System.Windows.Forms.Timer(components);
            Car1a = new PictureBox();
            Car2a = new PictureBox();
            Car3a = new PictureBox();
            Car1b = new PictureBox();
            Car1c = new PictureBox();
            Car3b = new PictureBox();
            Car3c = new PictureBox();
            Car2b = new PictureBox();
            Car2c = new PictureBox();
            Round = new Label();
            Lane1 = new PictureBox();
            Lane2 = new PictureBox();
            Lane3 = new PictureBox();
            SlowDown = new PictureBox();
            Shield = new PictureBox();
            CarSpeed = new Label();
            Fail = new Label();
            Player = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Car1a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car2a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car3a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car1b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car1c).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car3b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car3c).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car2b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car2c).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Lane1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Lane2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Lane3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SlowDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Shield).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Score
            // 
            Score.BackColor = Color.GreenYellow;
            Score.Font = new Font("Segoe UI Symbol", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Score.Location = new Point(1212, 9);
            Score.Name = "Score";
            Score.Size = new Size(336, 77);
            Score.TabIndex = 0;
            Score.Text = "Score: 0";
            // 
            // moveTimer
            // 
            moveTimer.Enabled = true;
            moveTimer.Interval = 20;
            moveTimer.Tick += moveTimerEvent;
            // 
            // Car1a
            // 
            Car1a.BackColor = Color.Red;
            Car1a.Location = new Point(12, 742);
            Car1a.Name = "Car1a";
            Car1a.Size = new Size(150, 75);
            Car1a.TabIndex = 3;
            Car1a.TabStop = false;
            Car1a.Tag = "Car";
            // 
            // Car2a
            // 
            Car2a.BackColor = Color.Red;
            Car2a.Location = new Point(1395, 462);
            Car2a.Name = "Car2a";
            Car2a.Size = new Size(150, 75);
            Car2a.TabIndex = 5;
            Car2a.TabStop = false;
            Car2a.Tag = "Car";
            // 
            // Car3a
            // 
            Car3a.BackColor = Color.Red;
            Car3a.Location = new Point(12, 180);
            Car3a.Name = "Car3a";
            Car3a.Size = new Size(150, 75);
            Car3a.TabIndex = 7;
            Car3a.TabStop = false;
            Car3a.Tag = "Car";
            // 
            // Car1b
            // 
            Car1b.BackColor = Color.Red;
            Car1b.Location = new Point(612, 742);
            Car1b.Name = "Car1b";
            Car1b.Size = new Size(150, 75);
            Car1b.TabIndex = 8;
            Car1b.TabStop = false;
            Car1b.Tag = "Car";
            // 
            // Car1c
            // 
            Car1c.BackColor = Color.Red;
            Car1c.Location = new Point(1212, 742);
            Car1c.Name = "Car1c";
            Car1c.Size = new Size(150, 75);
            Car1c.TabIndex = 9;
            Car1c.TabStop = false;
            Car1c.Tag = "Car";
            // 
            // Car3b
            // 
            Car3b.BackColor = Color.Red;
            Car3b.Location = new Point(612, 180);
            Car3b.Name = "Car3b";
            Car3b.Size = new Size(150, 75);
            Car3b.TabIndex = 10;
            Car3b.TabStop = false;
            Car3b.Tag = "Car";
            // 
            // Car3c
            // 
            Car3c.BackColor = Color.Red;
            Car3c.Location = new Point(1212, 180);
            Car3c.Name = "Car3c";
            Car3c.Size = new Size(150, 75);
            Car3c.TabIndex = 11;
            Car3c.TabStop = false;
            Car3c.Tag = "Car";
            // 
            // Car2b
            // 
            Car2b.BackColor = Color.Red;
            Car2b.Location = new Point(795, 462);
            Car2b.Name = "Car2b";
            Car2b.Size = new Size(150, 75);
            Car2b.TabIndex = 12;
            Car2b.TabStop = false;
            Car2b.Tag = "Car";
            // 
            // Car2c
            // 
            Car2c.BackColor = Color.Red;
            Car2c.Location = new Point(195, 462);
            Car2c.Name = "Car2c";
            Car2c.Size = new Size(150, 75);
            Car2c.TabIndex = 13;
            Car2c.TabStop = false;
            Car2c.Tag = "Car";
            // 
            // Round
            // 
            Round.BackColor = Color.GreenYellow;
            Round.Font = new Font("Arial Narrow", 30F);
            Round.Location = new Point(593, 9);
            Round.Name = "Round";
            Round.Size = new Size(377, 77);
            Round.TabIndex = 14;
            Round.Text = "Round: 1";
            Round.TextAlign = ContentAlignment.TopCenter;
            // 
            // Lane1
            // 
            Lane1.BackColor = Color.Silver;
            Lane1.Location = new Point(3, 776);
            Lane1.Name = "Lane1";
            Lane1.Size = new Size(1557, 10);
            Lane1.TabIndex = 16;
            Lane1.TabStop = false;
            Lane1.Tag = "Lane";
            // 
            // Lane2
            // 
            Lane2.BackColor = Color.Silver;
            Lane2.Location = new Point(13, 492);
            Lane2.Name = "Lane2";
            Lane2.Size = new Size(1557, 10);
            Lane2.TabIndex = 17;
            Lane2.TabStop = false;
            Lane2.Tag = "Lane";
            // 
            // Lane3
            // 
            Lane3.BackColor = Color.Silver;
            Lane3.Location = new Point(6, 213);
            Lane3.Name = "Lane3";
            Lane3.Size = new Size(1557, 10);
            Lane3.TabIndex = 18;
            Lane3.TabStop = false;
            Lane3.Tag = "Lane";
            // 
            // SlowDown
            // 
            SlowDown.BackColor = Color.GreenYellow;
            SlowDown.Image = Properties.Resources.red_timer_watch_in_pixel_art_style_vector_removebg_preview;
            SlowDown.Location = new Point(889, 862);
            SlowDown.Name = "SlowDown";
            SlowDown.Size = new Size(151, 143);
            SlowDown.SizeMode = PictureBoxSizeMode.StretchImage;
            SlowDown.TabIndex = 19;
            SlowDown.TabStop = false;
            SlowDown.Tag = "PowerUp";
            // 
            // Shield
            // 
            Shield.BackColor = Color.GreenYellow;
            Shield.Image = Properties.Resources.iron_shield_in_pixel_art_style_vector_removebg_preview;
            Shield.Location = new Point(489, 862);
            Shield.Name = "Shield";
            Shield.Size = new Size(165, 143);
            Shield.SizeMode = PictureBoxSizeMode.StretchImage;
            Shield.TabIndex = 20;
            Shield.TabStop = false;
            Shield.Tag = "PowerUp";
            // 
            // CarSpeed
            // 
            CarSpeed.BackColor = Color.GreenYellow;
            CarSpeed.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CarSpeed.Location = new Point(12, 917);
            CarSpeed.Name = "CarSpeed";
            CarSpeed.Size = new Size(382, 77);
            CarSpeed.TabIndex = 21;
            CarSpeed.Text = "Car Speed: 0";
            CarSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Fail
            // 
            Fail.BorderStyle = BorderStyle.FixedSingle;
            Fail.Font = new Font("Arial Narrow", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fail.Location = new Point(230, 191);
            Fail.Name = "Fail";
            Fail.Size = new Size(976, 508);
            Fail.TabIndex = 27;
            Fail.TextAlign = ContentAlignment.MiddleCenter;
            Fail.Visible = false;
            // 
            // Player
            // 
            Player.BackColor = Color.GreenYellow;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(689, 862);
            Player.Name = "Player";
            Player.Size = new Size(154, 132);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 1;
            Player.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(0, 646);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1563, 10);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "Cross";
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Location = new Point(3, 363);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1563, 10);
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "Cross";
            pictureBox3.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.GreenYellow;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1563, 1005);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 1006);
            Controls.Add(CarSpeed);
            Controls.Add(Shield);
            Controls.Add(SlowDown);
            Controls.Add(Round);
            Controls.Add(Car2c);
            Controls.Add(Car2b);
            Controls.Add(Car3c);
            Controls.Add(Car3b);
            Controls.Add(Car1c);
            Controls.Add(Car1b);
            Controls.Add(Player);
            Controls.Add(Car3a);
            Controls.Add(Car2a);
            Controls.Add(Car1a);
            Controls.Add(Score);
            Controls.Add(pictureBox1);
            Controls.Add(Fail);
            Controls.Add(pictureBox2);
            Controls.Add(Lane1);
            Controls.Add(Lane2);
            Controls.Add(pictureBox3);
            Controls.Add(Lane3);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            ((System.ComponentModel.ISupportInitialize)Car1a).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car2a).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car3a).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car1b).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car1c).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car3b).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car3c).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car2b).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car2c).EndInit();
            ((System.ComponentModel.ISupportInitialize)Lane1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Lane2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Lane3).EndInit();
            ((System.ComponentModel.ISupportInitialize)SlowDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Shield).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Score;
        private System.Windows.Forms.Timer moveTimer;
        private PictureBox Car1a;
        private PictureBox Car2a;
        private PictureBox Car3a;
        private PictureBox Car1b;
        private PictureBox Car1c;
        private PictureBox Car3b;
        private PictureBox Car3c;
        private PictureBox Car2b;
        private PictureBox Car2c;
        private Label Round;
        private PictureBox Lane1;
        private PictureBox Lane2;
        private PictureBox Lane3;
        private PictureBox SlowDown;
        private PictureBox Shield;
        private Label CarSpeed;
        private Label Fail;
        private PictureBox Player;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}
