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
            Player = new PictureBox();
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
            Fail = new Label();
            Lane1 = new PictureBox();
            Lane2 = new PictureBox();
            Lane3 = new PictureBox();
            Shield = new PictureBox();
            SlowDown = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)Shield).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SlowDown).BeginInit();
            SuspendLayout();
            // 
            // Score
            // 
            Score.Font = new Font("Segoe UI Symbol", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Score.Location = new Point(1301, 9);
            Score.Name = "Score";
            Score.Size = new Size(247, 77);
            Score.TabIndex = 0;
            Score.Text = "Score: 0";
            // 
            // Player
            // 
            Player.BackColor = Color.Blue;
            Player.Location = new Point(710, 861);
            Player.Name = "Player";
            Player.Size = new Size(150, 117);
            Player.TabIndex = 1;
            Player.TabStop = false;
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
            Road1.Location = new Point(1, 630);
            Road1.Name = "Road1";
            Road1.Size = new Size(1558, 134);
            Road1.TabIndex = 2;
            Road1.TabStop = false;
            // 
            // Car1a
            // 
            Car1a.BackColor = Color.Red;
            Car1a.Location = new Point(12, 662);
            Car1a.Name = "Car1a";
            Car1a.Size = new Size(150, 75);
            Car1a.TabIndex = 3;
            Car1a.TabStop = false;
            Car1a.Tag = "Car";
            // 
            // Car2a
            // 
            Car2a.BackColor = Color.Red;
            Car2a.Location = new Point(1398, 381);
            Car2a.Name = "Car2a";
            Car2a.Size = new Size(150, 75);
            Car2a.TabIndex = 5;
            Car2a.TabStop = false;
            Car2a.Tag = "Car";
            // 
            // Road2
            // 
            Road2.BackColor = Color.Gray;
            Road2.Location = new Point(1, 350);
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
            Car1b.Location = new Point(612, 662);
            Car1b.Name = "Car1b";
            Car1b.Size = new Size(150, 75);
            Car1b.TabIndex = 8;
            Car1b.TabStop = false;
            Car1b.Tag = "Car";
            // 
            // Car1c
            // 
            Car1c.BackColor = Color.Red;
            Car1c.Location = new Point(1212, 662);
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
            Car2b.Location = new Point(798, 381);
            Car2b.Name = "Car2b";
            Car2b.Size = new Size(150, 75);
            Car2b.TabIndex = 12;
            Car2b.TabStop = false;
            Car2b.Tag = "Car";
            // 
            // Car2c
            // 
            Car2c.BackColor = Color.Red;
            Car2c.Location = new Point(198, 381);
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
            // Fail
            // 
            Fail.BorderStyle = BorderStyle.FixedSingle;
            Fail.Font = new Font("Arial Narrow", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fail.Location = new Point(321, 152);
            Fail.Name = "Fail";
            Fail.Size = new Size(976, 554);
            Fail.TabIndex = 15;
            Fail.TextAlign = ContentAlignment.MiddleCenter;
            Fail.Visible = false;
            // 
            // Lane1
            // 
            Lane1.BackColor = Color.Silver;
            Lane1.Location = new Point(1, 696);
            Lane1.Name = "Lane1";
            Lane1.Size = new Size(1557, 10);
            Lane1.TabIndex = 16;
            Lane1.TabStop = false;
            Lane1.Tag = "Lane";
            // 
            // Lane2
            // 
            Lane2.BackColor = Color.Silver;
            Lane2.Location = new Point(2, 413);
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
            // Shield
            // 
            Shield.BackColor = Color.Yellow;
            Shield.Location = new Point(71, 861);
            Shield.Name = "Shield";
            Shield.Size = new Size(91, 75);
            Shield.TabIndex = 19;
            Shield.TabStop = false;
            Shield.Tag = "Shield";
            // 
            // SlowDown
            // 
            SlowDown.BackColor = Color.Purple;
            SlowDown.Location = new Point(277, 861);
            SlowDown.Name = "SlowDown";
            SlowDown.Size = new Size(91, 75);
            SlowDown.TabIndex = 20;
            SlowDown.TabStop = false;
            SlowDown.Tag = "SlowDown";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 1006);
            Controls.Add(SlowDown);
            Controls.Add(Shield);
            Controls.Add(Fail);
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
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)Shield).EndInit();
            ((System.ComponentModel.ISupportInitialize)SlowDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Score;
        private PictureBox Player;
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
        private Label Fail;
        private PictureBox Lane1;
        private PictureBox Lane2;
        private PictureBox Lane3;
        private PictureBox Shield;
        private PictureBox SlowDown;
    }
}
