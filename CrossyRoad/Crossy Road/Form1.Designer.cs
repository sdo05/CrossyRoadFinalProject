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
            Car1 = new PictureBox();
            Car2 = new PictureBox();
            Road2 = new PictureBox();
            Car3 = new PictureBox();
            Road3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Road1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Road2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Road3).BeginInit();
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
            Player.Location = new Point(705, 888);
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
            // Car1
            // 
            Car1.BackColor = Color.Red;
            Car1.Location = new Point(12, 662);
            Car1.Name = "Car1";
            Car1.Size = new Size(150, 75);
            Car1.TabIndex = 3;
            Car1.TabStop = false;
            // 
            // Car2
            // 
            Car2.BackColor = Color.Red;
            Car2.Location = new Point(1398, 381);
            Car2.Name = "Car2";
            Car2.Size = new Size(150, 75);
            Car2.TabIndex = 5;
            Car2.TabStop = false;
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
            // Car3
            // 
            Car3.BackColor = Color.Red;
            Car3.Location = new Point(12, 132);
            Car3.Name = "Car3";
            Car3.Size = new Size(150, 75);
            Car3.TabIndex = 7;
            Car3.TabStop = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 1006);
            Controls.Add(Car3);
            Controls.Add(Road3);
            Controls.Add(Car2);
            Controls.Add(Road2);
            Controls.Add(Car1);
            Controls.Add(Road1);
            Controls.Add(Player);
            Controls.Add(Score);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Road1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Road2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Road3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Score;
        private PictureBox Player;
        private System.Windows.Forms.Timer moveTimer;
        private PictureBox Road1;
        private PictureBox Car1;
        private PictureBox Car2;
        private PictureBox Road2;
        private PictureBox Car3;
        private PictureBox Road3;
    }
}
