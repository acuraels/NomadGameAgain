using System;
using System.Windows.Forms;

namespace NomadGameAgain.GameObjects
{
    public class Player : Unit
    {
        private Timer timerUpdate;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBox1;


        private int speed = 5;

        private new void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 33;
            this.timerUpdate.Tick += new System.EventHandler(this.Update);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox1.Image = global::NomadGameAgain.Properties.Resources.medievalUnit_02;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Player
            // 
            this.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.Controls.Add(this.pictureBox1);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(55, 62);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public Player()
        {
            InitializeComponent();
        }

        private void Update(object sender, EventArgs e)
        {
            if (Core.IsUp && Top > 0)
                Top -= speed;
            if (Core.IsDown && Bottom < this.Parent.Height)
                Top += speed;
            if (Core.IsLeft && Left > 0)
                Left -= speed;
            if (Core.IsRight && Right < this.Parent.Width)
                Left += speed;
        }
    }
}