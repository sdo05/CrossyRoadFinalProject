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
            PlayerSpeed = new Label();
            NewGame = new Label();
            pictureBox1 = new PictureBox();
            Yes = new Label();
            No = new Label();
            Impossible = new Label();
            Hard = new Label();
            Medium = new Label();
            Normal = new Label();
            Easy = new Label();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            Car1a.BackColor = Color.Transparent;
            Car1a.Image = (Image)resources.GetObject("Car1a.Image");
            Car1a.Location = new Point(12, 742);
            Car1a.Name = "Car1a";
            Car1a.Size = new Size(150, 75);
            Car1a.SizeMode = PictureBoxSizeMode.StretchImage;
            Car1a.TabIndex = 3;
            Car1a.TabStop = false;
            Car1a.Tag = "Car";
            // 
            // Car2a
            // 
            Car2a.BackColor = Color.Transparent;
            Car2a.Image = (Image)resources.GetObject("Car2a.Image");
            Car2a.Location = new Point(1395, 462);
            Car2a.Name = "Car2a";
            Car2a.Size = new Size(150, 75);
            Car2a.SizeMode = PictureBoxSizeMode.StretchImage;
            Car2a.TabIndex = 5;
            Car2a.TabStop = false;
            Car2a.Tag = "Car";
            // 
            // Car3a
            // 
            Car3a.BackColor = Color.Transparent;
            Car3a.Image = (Image)resources.GetObject("Car3a.Image");
            Car3a.Location = new Point(12, 180);
            Car3a.Name = "Car3a";
            Car3a.Size = new Size(150, 75);
            Car3a.SizeMode = PictureBoxSizeMode.StretchImage;
            Car3a.TabIndex = 7;
            Car3a.TabStop = false;
            Car3a.Tag = "Car";
            // 
            // Car1b
            // 
            Car1b.BackColor = Color.Transparent;
            Car1b.Image = (Image)resources.GetObject("Car1b.Image");
            Car1b.Location = new Point(612, 742);
            Car1b.Name = "Car1b";
            Car1b.Size = new Size(150, 75);
            Car1b.SizeMode = PictureBoxSizeMode.StretchImage;
            Car1b.TabIndex = 8;
            Car1b.TabStop = false;
            Car1b.Tag = "Car";
            // 
            // Car1c
            // 
            Car1c.BackColor = Color.Transparent;
            Car1c.Image = (Image)resources.GetObject("Car1c.Image");
            Car1c.Location = new Point(1212, 742);
            Car1c.Name = "Car1c";
            Car1c.Size = new Size(150, 75);
            Car1c.SizeMode = PictureBoxSizeMode.StretchImage;
            Car1c.TabIndex = 9;
            Car1c.TabStop = false;
            Car1c.Tag = "Car";
            // 
            // Car3b
            // 
            Car3b.BackColor = Color.Transparent;
            Car3b.Image = (Image)resources.GetObject("Car3b.Image");
            Car3b.Location = new Point(612, 180);
            Car3b.Name = "Car3b";
            Car3b.Size = new Size(150, 75);
            Car3b.SizeMode = PictureBoxSizeMode.StretchImage;
            Car3b.TabIndex = 10;
            Car3b.TabStop = false;
            Car3b.Tag = "Car";
            // 
            // Car3c
            // 
            Car3c.BackColor = Color.Transparent;
            Car3c.Image = (Image)resources.GetObject("Car3c.Image");
            Car3c.Location = new Point(1212, 180);
            Car3c.Name = "Car3c";
            Car3c.Size = new Size(150, 75);
            Car3c.SizeMode = PictureBoxSizeMode.StretchImage;
            Car3c.TabIndex = 11;
            Car3c.TabStop = false;
            Car3c.Tag = "Car";
            // 
            // Car2b
            // 
            Car2b.BackColor = Color.Transparent;
            Car2b.Image = (Image)resources.GetObject("Car2b.Image");
            Car2b.Location = new Point(795, 462);
            Car2b.Name = "Car2b";
            Car2b.Size = new Size(150, 75);
            Car2b.SizeMode = PictureBoxSizeMode.StretchImage;
            Car2b.TabIndex = 12;
            Car2b.TabStop = false;
            Car2b.Tag = "Car";
            // 
            // Car2c
            // 
            Car2c.BackColor = Color.Transparent;
            Car2c.Image = (Image)resources.GetObject("Car2c.Image");
            Car2c.Location = new Point(195, 462);
            Car2c.Name = "Car2c";
            Car2c.Size = new Size(150, 75);
            Car2c.SizeMode = PictureBoxSizeMode.StretchImage;
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
            Lane2.Location = new Point(0, 496);
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
            Player.BackgroundImageLayout = ImageLayout.None;
            Player.Image = Properties.Resources.thumbnail_IMG_3251_removebg_preview;
            Player.Location = new Point(711, 862);
            Player.Name = "Player";
            Player.Size = new Size(123, 132);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 1;
            Player.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(-3, 590);
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
            pictureBox3.Location = new Point(-15, 302);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1563, 10);
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "Cross";
            pictureBox3.Visible = false;
            // 
            // PlayerSpeed
            // 
            PlayerSpeed.BackColor = Color.GreenYellow;
            PlayerSpeed.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerSpeed.Location = new Point(1116, 917);
            PlayerSpeed.Name = "PlayerSpeed";
            PlayerSpeed.Size = new Size(432, 77);
            PlayerSpeed.TabIndex = 35;
            PlayerSpeed.Text = "Player Speed: 0";
            PlayerSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NewGame
            // 
            NewGame.BackColor = SystemColors.ActiveCaption;
            NewGame.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewGame.Location = new Point(8, 8);
            NewGame.Name = "NewGame";
            NewGame.Size = new Size(208, 78);
            NewGame.TabIndex = 36;
            NewGame.Text = "New Game";
            NewGame.TextAlign = ContentAlignment.MiddleCenter;
            NewGame.Click += NewGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.GreenYellow;
            pictureBox1.Image = Properties.Resources.pixil_frame_0__2__removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1560, 1005);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // Yes
            // 
            Yes.BackColor = SystemColors.ActiveCaption;
            Yes.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Yes.Location = new Point(291, 727);
            Yes.Name = "Yes";
            Yes.Size = new Size(258, 107);
            Yes.TabIndex = 38;
            Yes.Text = "Yes";
            Yes.TextAlign = ContentAlignment.MiddleCenter;
            Yes.Visible = false;
            Yes.Click += Yes_Click;
            // 
            // No
            // 
            No.BackColor = SystemColors.ActiveCaption;
            No.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            No.Location = new Point(861, 727);
            No.Name = "No";
            No.Size = new Size(258, 107);
            No.TabIndex = 39;
            No.Text = "No";
            No.TextAlign = ContentAlignment.MiddleCenter;
            No.Visible = false;
            No.Click += No_Click;
            // 
            // Impossible
            // 
            Impossible.BackColor = SystemColors.ActiveCaption;
            Impossible.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Impossible.Location = new Point(881, 645);
            Impossible.Name = "Impossible";
            Impossible.Size = new Size(296, 147);
            Impossible.TabIndex = 69;
            Impossible.Text = "Impossible";
            Impossible.TextAlign = ContentAlignment.MiddleCenter;
            Impossible.Click += Impossible_Click;
            // 
            // Hard
            // 
            Hard.BackColor = SystemColors.ActiveCaption;
            Hard.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hard.Location = new Point(398, 645);
            Hard.Name = "Hard";
            Hard.Size = new Size(296, 147);
            Hard.TabIndex = 70;
            Hard.Text = "Hard";
            Hard.TextAlign = ContentAlignment.MiddleCenter;
            Hard.Click += Hard_Click;
            // 
            // Medium
            // 
            Medium.BackColor = SystemColors.ActiveCaption;
            Medium.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Medium.Location = new Point(1099, 389);
            Medium.Name = "Medium";
            Medium.Size = new Size(296, 147);
            Medium.TabIndex = 68;
            Medium.Text = "Medium";
            Medium.TextAlign = ContentAlignment.MiddleCenter;
            Medium.Click += Medium_Click;
            // 
            // Normal
            // 
            Normal.BackColor = SystemColors.ActiveCaption;
            Normal.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Normal.Location = new Point(627, 389);
            Normal.Name = "Normal";
            Normal.Size = new Size(296, 147);
            Normal.TabIndex = 67;
            Normal.Text = "Normal";
            Normal.TextAlign = ContentAlignment.MiddleCenter;
            Normal.Click += Normal_Click;
            // 
            // Easy
            // 
            Easy.BackColor = SystemColors.ActiveCaption;
            Easy.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Easy.Location = new Point(166, 389);
            Easy.Name = "Easy";
            Easy.Size = new Size(296, 147);
            Easy.TabIndex = 66;
            Easy.Text = "Easy";
            Easy.TextAlign = ContentAlignment.MiddleCenter;
            Easy.Click += Easy_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkGray;
            label6.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(166, 215);
            label6.Name = "label6";
            label6.Size = new Size(1229, 87);
            label6.TabIndex = 71;
            label6.Text = "Choose Your Difficulty Level";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.LightGray;
            pictureBox5.Location = new Point(81, 135);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1390, 703);
            pictureBox5.TabIndex = 73;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1560, 1022);
            pictureBox4.TabIndex = 72;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 1006);
            Controls.Add(Impossible);
            Controls.Add(Hard);
            Controls.Add(Medium);
            Controls.Add(Normal);
            Controls.Add(Easy);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(No);
            Controls.Add(Yes);
            Controls.Add(Player);
            Controls.Add(NewGame);
            Controls.Add(PlayerSpeed);
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
            Controls.Add(Car3a);
            Controls.Add(Car2a);
            Controls.Add(Car1a);
            Controls.Add(Score);
            Controls.Add(pictureBox1);
            Controls.Add(Fail);
            Controls.Add(Lane2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Lane1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private Label PlayerSpeed;
        private Label NewGame;
        private PictureBox pictureBox1;
        private Label Yes;
        private Label No;
        private Label Impossible;
        private Label Hard;
        private Label Medium;
        private Label Normal;
        private Label Easy;
        private Label label6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}
