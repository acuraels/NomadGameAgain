using System;
using System.Windows.Forms;

namespace NomadGameAgain.GameObjects
{
    public class Coin : UserControl
    {
        private PictureBox pictureBox1;

        public Coin(int x, int y) 
        {
            Location = new System.Drawing.Point(x, y);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox1.Image = global::NomadGameAgain.Properties.Resources._1678470005;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Coin
            // 
            this.Controls.Add(this.pictureBox1);
            this.Name = "Coin";
            this.Size = new System.Drawing.Size(34, 34);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public Coin()
        {
            InitializeComponent();
        }
    }
}
