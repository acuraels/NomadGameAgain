using System;
using System.Drawing;
using System.Windows.Forms;

namespace NomadGameAgain.GameObjects
{
    public class BotGatherer : Unit
    {
        private Timer timerBot;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBox1;

        private int speed = 3;

        public BotGatherer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerBot = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBot
            // 
            this.timerBot.Enabled = true;
            this.timerBot.Interval = 33;
            this.timerBot.Tick += new System.EventHandler(this.Update);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox1.Image = global::NomadGameAgain.Properties.Resources.medievalUnit_15;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BotGatherer
            // 
            this.Controls.Add(this.pictureBox1);
            this.Name = "BotGatherer";
            this.Size = new System.Drawing.Size(45, 68);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Update(object sender, EventArgs e)
        {
            Coin c = GetClosest();

            if(c != null)
                MoveTowards(c.Location.X, c.Location.Y, speed);
        }

        public void MoveTowards(int x, int y, float speed) 
        {
            Point pt = Location;

            var tx = x - pt.X;
            var ty = y - pt.Y;
            var length = (float)Math.Sqrt(tx * tx + ty * ty);

            if (length > speed) 
            {
                pt.X = (int)(pt.X + speed * tx / length);
                pt.Y = (int)(pt.Y + speed * ty / length);

                Location = new Point(pt.X, pt.Y);
            }

            else
            {
                pt.X = x;
                pt.Y = y;

                Location = new Point(pt.X, pt.Y);
            }
        }

        private Coin GetClosest()
        {
            Coin c = null;
            var distClosest = 9999;

            if(Core.CoinsList.Count > 0)
            {
                foreach (var item in Core.CoinsList)
                {
                    var tx = item.Location.X - Location.X;
                    var ty = item.Location.Y - Location.Y;

                    var length = (int)Math.Sqrt(tx *tx + ty * ty);

                    if(length < distClosest)
                    {
                        distClosest = length;
                        c = item;
                    }
                }
            }
            return c;
        }
    }
}
