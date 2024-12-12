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
            Score = new Label();
            moveTimer = new System.Windows.Forms.Timer(components);
            Road1 = new PictureBox();
            Car1a = new PictureBox();
            Car2a = new PictureBox();
            Road2 = new PictureBox();
            Car3a = new PictureBox();
            Road3 = new PictureBox();
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
            Tree1 = new PictureBox();
            Tree2 = new PictureBox();
            Tree3 = new PictureBox();
            Tree4 = new PictureBox();
            Tree6 = new PictureBox();
            Fail = new Label();
            Tree7 = new PictureBox();
            Tree5 = new PictureBox();
            Player = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Road1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car1a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car2a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Road2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car3a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Road3).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)Tree1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tree2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tree3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tree4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tree6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tree7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tree5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Score
            // 
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
            // Road1
            // 
            Road1.BackColor = Color.Gray;
            Road1.BackgroundImageLayout = ImageLayout.Center;
            Road1.Location = new Point(2, 679);
            Road1.Name = "Road1";
            Road1.Size = new Size(1558, 134);
            Road1.TabIndex = 2;
            Road1.TabStop = false;
            // 
            // Car1a
            // 
            Car1a.BackColor = Color.Red;
            Car1a.Location = new Point(13, 711);
            Car1a.Name = "Car1a";
            Car1a.Size = new Size(150, 75);
            Car1a.TabIndex = 3;
            Car1a.TabStop = false;
            Car1a.Tag = "Car";
            // 
            // Car2a
            // 
            Car2a.BackColor = Color.Red;
            Car2a.Location = new Point(1399, 411);
            Car2a.Name = "Car2a";
            Car2a.Size = new Size(150, 75);
            Car2a.TabIndex = 5;
            Car2a.TabStop = false;
            Car2a.Tag = "Car";
            // 
            // Road2
            // 
            Road2.BackColor = Color.Gray;
            Road2.Location = new Point(2, 380);
            Road2.Name = "Road2";
            Road2.Size = new Size(1558, 134);
            Road2.TabIndex = 4;
            Road2.TabStop = false;
            // 
            // Car3a
            // 
            Car3a.BackColor = Color.Red;
            Car3a.Location = new Point(12, 132);
            Car3a.Name = "Car3a";
            Car3a.Size = new Size(150, 75);
            Car3a.TabIndex = 7;
            Car3a.TabStop = false;
            Car3a.Tag = "Car";
            // 
            // Road3
            // 
            Road3.BackColor = Color.Gray;
            Road3.Location = new Point(1, 105);
            Road3.Name = "Road3";
            Road3.Size = new Size(1558, 134);
            Road3.TabIndex = 6;
            Road3.TabStop = false;
            // 
            // Car1b
            // 
            Car1b.BackColor = Color.Red;
            Car1b.Location = new Point(613, 711);
            Car1b.Name = "Car1b";
            Car1b.Size = new Size(150, 75);
            Car1b.TabIndex = 8;
            Car1b.TabStop = false;
            Car1b.Tag = "Car";
            // 
            // Car1c
            // 
            Car1c.BackColor = Color.Red;
            Car1c.Location = new Point(1213, 711);
            Car1c.Name = "Car1c";
            Car1c.Size = new Size(150, 75);
            Car1c.TabIndex = 9;
            Car1c.TabStop = false;
            Car1c.Tag = "Car";
            // 
            // Car3b
            // 
            Car3b.BackColor = Color.Red;
            Car3b.Location = new Point(612, 132);
            Car3b.Name = "Car3b";
            Car3b.Size = new Size(150, 75);
            Car3b.TabIndex = 10;
            Car3b.TabStop = false;
            Car3b.Tag = "Car";
            // 
            // Car3c
            // 
            Car3c.BackColor = Color.Red;
            Car3c.Location = new Point(1212, 132);
            Car3c.Name = "Car3c";
            Car3c.Size = new Size(150, 75);
            Car3c.TabIndex = 11;
            Car3c.TabStop = false;
            Car3c.Tag = "Car";
            // 
            // Car2b
            // 
            Car2b.BackColor = Color.Red;
            Car2b.Location = new Point(799, 411);
            Car2b.Name = "Car2b";
            Car2b.Size = new Size(150, 75);
            Car2b.TabIndex = 12;
            Car2b.TabStop = false;
            Car2b.Tag = "Car";
            // 
            // Car2c
            // 
            Car2c.BackColor = Color.Red;
            Car2c.Location = new Point(199, 411);
            Car2c.Name = "Car2c";
            Car2c.Size = new Size(150, 75);
            Car2c.TabIndex = 13;
            Car2c.TabStop = false;
            Car2c.Tag = "Car";
            // 
            // Round
            // 
            Round.Font = new Font("Arial Narrow", 30F);
            Round.Location = new Point(612, 9);
            Round.Name = "Round";
            Round.Size = new Size(377, 77);
            Round.TabIndex = 14;
            Round.Text = "Round: 1";
            // 
            // Lane1
            // 
            Lane1.BackColor = Color.Silver;
            Lane1.Location = new Point(2, 745);
            Lane1.Name = "Lane1";
            Lane1.Size = new Size(1557, 10);
            Lane1.TabIndex = 16;
            Lane1.TabStop = false;
            Lane1.Tag = "Lane";
            // 
            // Lane2
            // 
            Lane2.BackColor = Color.Silver;
            Lane2.Location = new Point(3, 443);
            Lane2.Name = "Lane2";
            Lane2.Size = new Size(1557, 10);
            Lane2.TabIndex = 17;
            Lane2.TabStop = false;
            Lane2.Tag = "Lane";
            // 
            // Lane3
            // 
            Lane3.BackColor = Color.Silver;
            Lane3.Location = new Point(2, 167);
            Lane3.Name = "Lane3";
            Lane3.Size = new Size(1557, 10);
            Lane3.TabIndex = 18;
            Lane3.TabStop = false;
            Lane3.Tag = "Lane";
            // 
            // SlowDown
            // 
            SlowDown.BackColor = Color.Purple;
            SlowDown.Location = new Point(1000, 873);
            SlowDown.Name = "SlowDown";
            SlowDown.Size = new Size(78, 75);
            SlowDown.TabIndex = 19;
            SlowDown.TabStop = false;
            SlowDown.Tag = "PowerUp";
            // 
            // Shield
            // 
            Shield.BackColor = Color.Yellow;
            Shield.Location = new Point(400, 873);
            Shield.Name = "Shield";
            Shield.Size = new Size(78, 75);
            Shield.TabIndex = 20;
            Shield.TabStop = false;
            Shield.Tag = "PowerUp";
            // 
            // CarSpeed
            // 
            CarSpeed.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CarSpeed.Location = new Point(12, 917);
            CarSpeed.Name = "CarSpeed";
            CarSpeed.Size = new Size(382, 77);
            CarSpeed.TabIndex = 21;
            CarSpeed.Text = "Car Speed: 0";
            CarSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tree1
            // 
            Tree1.BackColor = Color.Green;
            Tree1.Location = new Point(12, 537);
            Tree1.Name = "Tree1";
            Tree1.Size = new Size(134, 109);
            Tree1.TabIndex = 22;
            Tree1.TabStop = false;
            Tree1.Tag = "Tree";
            // 
            // Tree2
            // 
            Tree2.BackColor = Color.Green;
            Tree2.Location = new Point(510, 537);
            Tree2.Name = "Tree2";
            Tree2.Size = new Size(134, 109);
            Tree2.TabIndex = 23;
            Tree2.TabStop = false;
            Tree2.Tag = "Tree";
            // 
            // Tree3
            // 
            Tree3.BackColor = Color.Green;
            Tree3.Location = new Point(1012, 537);
            Tree3.Name = "Tree3";
            Tree3.Size = new Size(134, 109);
            Tree3.TabIndex = 24;
            Tree3.TabStop = false;
            Tree3.Tag = "Tree";
            // 
            // Tree4
            // 
            Tree4.BackColor = Color.Green;
            Tree4.Location = new Point(1414, 537);
            Tree4.Name = "Tree4";
            Tree4.Size = new Size(134, 109);
            Tree4.TabIndex = 25;
            Tree4.TabStop = false;
            Tree4.Tag = "Tree";
            // 
            // Tree6
            // 
            Tree6.BackColor = Color.Green;
            Tree6.Location = new Point(746, 254);
            Tree6.Name = "Tree6";
            Tree6.Size = new Size(134, 109);
            Tree6.TabIndex = 26;
            Tree6.TabStop = false;
            Tree6.Tag = "Tree";
            // 
            // Fail
            // 
            Fail.BorderStyle = BorderStyle.FixedSingle;
            Fail.Font = new Font("Arial Narrow", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fail.Location = new Point(1030, 19);
            Fail.Name = "Fail";
            Fail.Size = new Size(99, 53);
            Fail.TabIndex = 27;
            Fail.TextAlign = ContentAlignment.MiddleCenter;
            Fail.Visible = false;
            // 
            // Tree7
            // 
            Tree7.BackColor = Color.Green;
            Tree7.Location = new Point(1228, 254);
            Tree7.Name = "Tree7";
            Tree7.Size = new Size(134, 109);
            Tree7.TabIndex = 28;
            Tree7.TabStop = false;
            Tree7.Tag = "Tree";
            // 
            // Tree5
            // 
            Tree5.BackColor = Color.Green;
            Tree5.Location = new Point(260, 254);
            Tree5.Name = "Tree5";
            Tree5.Size = new Size(134, 109);
            Tree5.TabIndex = 29;
            Tree5.TabStop = false;
            Tree5.Tag = "Tree";
            // 
            // Player
            // 
            Player.BackColor = Color.Blue;
            Player.Location = new Point(705, 888);
            Player.Name = "Player";
            Player.Size = new Size(134, 109);
            Player.TabIndex = 1;
            Player.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Blue;
            pictureBox1.Location = new Point(152, 537);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 109);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 583);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1563, 10);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "Cross";
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(0, 300);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1563, 10);
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "Cross";
            pictureBox3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 1006);
            Controls.Add(pictureBox1);
            Controls.Add(Fail);
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
            Controls.Add(Road3);
            Controls.Add(Car2a);
            Controls.Add(Road2);
            Controls.Add(Car1a);
            Controls.Add(Road1);
            Controls.Add(Score);
            Controls.Add(Lane1);
            Controls.Add(Lane2);
            Controls.Add(Lane3);
            Controls.Add(Tree5);
            Controls.Add(Tree7);
            Controls.Add(Tree6);
            Controls.Add(Tree4);
            Controls.Add(Tree3);
            Controls.Add(Tree2);
            Controls.Add(Tree1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            ((System.ComponentModel.ISupportInitialize)Road1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car1a).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car2a).EndInit();
            ((System.ComponentModel.ISupportInitialize)Road2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car3a).EndInit();
            ((System.ComponentModel.ISupportInitialize)Road3).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)Tree1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tree2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tree3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tree4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tree6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tree7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tree5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Score;
        private System.Windows.Forms.Timer moveTimer;
        private PictureBox Road1;
        private PictureBox Car1a;
        private PictureBox Car2a;
        private PictureBox Road2;
        private PictureBox Car3a;
        private PictureBox Road3;
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
        private PictureBox Tree1;
        private PictureBox Tree2;
        private PictureBox Tree3;
        private PictureBox Tree4;
        private PictureBox Tree6;
        private Label Fail;
        private PictureBox Tree7;
        private PictureBox Tree5;
        private PictureBox Player;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
