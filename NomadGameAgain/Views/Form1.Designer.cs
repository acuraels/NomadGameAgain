namespace NomadGameAgain
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerCoins = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelCoinsLeft = new System.Windows.Forms.Label();
            this.labelCoinsGathered = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.botGatherer1 = new NomadGameAgain.GameObjects.BotGatherer();
            this.player1 = new NomadGameAgain.GameObjects.Player();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCoins
            // 
            this.timerCoins.Enabled = true;
            this.timerCoins.Interval = 1000;
            this.timerCoins.Tick += new System.EventHandler(this.Coin_Generate);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 33;
            this.timerUpdate.Tick += new System.EventHandler(this.Update);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox14.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_12;
            this.pictureBox14.Location = new System.Drawing.Point(640, 214);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(103, 94);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 18;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox13.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_06;
            this.pictureBox13.Location = new System.Drawing.Point(65, 334);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(133, 122);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 17;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox12.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_02;
            this.pictureBox12.Location = new System.Drawing.Point(65, 239);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(133, 101);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox4.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_18;
            this.pictureBox4.Location = new System.Drawing.Point(531, 431);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(151, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox11.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_18;
            this.pictureBox11.Location = new System.Drawing.Point(804, 32);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(151, 122);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 14;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox10.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_19;
            this.pictureBox10.Location = new System.Drawing.Point(216, 75);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(65, 71);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox9.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_19;
            this.pictureBox9.Location = new System.Drawing.Point(301, 431);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(65, 71);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox8.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_19;
            this.pictureBox8.Location = new System.Drawing.Point(1165, 446);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(65, 71);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox7.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_19;
            this.pictureBox7.Location = new System.Drawing.Point(869, 404);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(133, 128);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox6.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_18;
            this.pictureBox6.Location = new System.Drawing.Point(365, 15);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(124, 132);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // labelCoinsLeft
            // 
            this.labelCoinsLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCoinsLeft.AutoSize = true;
            this.labelCoinsLeft.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoinsLeft.ForeColor = System.Drawing.Color.Red;
            this.labelCoinsLeft.Image = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.labelCoinsLeft.Location = new System.Drawing.Point(1147, 32);
            this.labelCoinsLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoinsLeft.Name = "labelCoinsLeft";
            this.labelCoinsLeft.Size = new System.Drawing.Size(77, 31);
            this.labelCoinsLeft.TabIndex = 8;
            this.labelCoinsLeft.Text = "0 left";
            // 
            // labelCoinsGathered
            // 
            this.labelCoinsGathered.AutoSize = true;
            this.labelCoinsGathered.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoinsGathered.ForeColor = System.Drawing.Color.Yellow;
            this.labelCoinsGathered.Image = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.labelCoinsGathered.Location = new System.Drawing.Point(59, 32);
            this.labelCoinsGathered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoinsGathered.Name = "labelCoinsGathered";
            this.labelCoinsGathered.Size = new System.Drawing.Size(99, 31);
            this.labelCoinsGathered.TabIndex = 7;
            this.labelCoinsGathered.Text = "0 coins";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox5.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_19;
            this.pictureBox5.Location = new System.Drawing.Point(737, 351);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox3.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_17;
            this.pictureBox3.Location = new System.Drawing.Point(1153, 181);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox2.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_18;
            this.pictureBox2.Location = new System.Drawing.Point(277, 265);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1329, 575);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox16.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_19;
            this.pictureBox16.Location = new System.Drawing.Point(1055, 98);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(65, 71);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox16.TabIndex = 20;
            this.pictureBox16.TabStop = false;
            // 
            // botGatherer1
            // 
            this.botGatherer1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.botGatherer1.Location = new System.Drawing.Point(915, 271);
            this.botGatherer1.Margin = new System.Windows.Forms.Padding(4);
            this.botGatherer1.Name = "botGatherer1";
            this.botGatherer1.Size = new System.Drawing.Size(60, 69);
            this.botGatherer1.TabIndex = 6;
            // 
            // player1
            // 
            this.player1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.player1.Location = new System.Drawing.Point(531, 181);
            this.player1.Margin = new System.Windows.Forms.Padding(4);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(65, 73);
            this.player1.TabIndex = 0;
            this.player1.Load += new System.EventHandler(this.player1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 567);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.labelCoinsLeft);
            this.Controls.Add(this.labelCoinsGathered);
            this.Controls.Add(this.botGatherer1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameObjects.Player player1;
        private System.Windows.Forms.Timer timerCoins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timerUpdate;
        private GameObjects.BotGatherer botGatherer1;
        private System.Windows.Forms.Label labelCoinsGathered;
        private System.Windows.Forms.Label labelCoinsLeft;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox16;
    }
}

