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
            this.labelCoinsLeft = new System.Windows.Forms.Label();
            this.labelCoinsGathered = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.obstacleCenter = new System.Windows.Forms.PictureBox();
            this.houseObstacle1 = new System.Windows.Forms.PictureBox();
            this.houseObstacle2 = new System.Windows.Forms.PictureBox();
            this.player1 = new NomadGameAgain.GameObjects.Player();
            this.botGatherer1 = new NomadGameAgain.GameObjects.BotGatherer();
            this.bushObstacle3 = new System.Windows.Forms.PictureBox();
            this.bushObstacle1 = new System.Windows.Forms.PictureBox();
            this.bushObstacle4 = new System.Windows.Forms.PictureBox();
            this.bushObstacle2 = new System.Windows.Forms.PictureBox();
            this.houseObstacle3 = new System.Windows.Forms.PictureBox();
            this.logObstacle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseObstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseObstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushObstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushObstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushObstacle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushObstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseObstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logObstacle)).BeginInit();
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
            // labelCoinsLeft
            // 
            this.labelCoinsLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCoinsLeft.AutoSize = true;
            this.labelCoinsLeft.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoinsLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelCoinsLeft.Image = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.labelCoinsLeft.Location = new System.Drawing.Point(133, -3);
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
            this.labelCoinsGathered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCoinsGathered.Image = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.labelCoinsGathered.Location = new System.Drawing.Point(0, -3);
            this.labelCoinsGathered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoinsGathered.Name = "labelCoinsGathered";
            this.labelCoinsGathered.Size = new System.Drawing.Size(99, 31);
            this.labelCoinsGathered.TabIndex = 7;
            this.labelCoinsGathered.Text = "0 coins";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1329, 575);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // obstacleCenter
            // 
            this.obstacleCenter.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.obstacleCenter.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_12;
            this.obstacleCenter.Location = new System.Drawing.Point(691, 207);
            this.obstacleCenter.Name = "obstacleCenter";
            this.obstacleCenter.Size = new System.Drawing.Size(77, 88);
            this.obstacleCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.obstacleCenter.TabIndex = 9;
            this.obstacleCenter.TabStop = false;
            this.obstacleCenter.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // houseObstacle1
            // 
            this.houseObstacle1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.houseObstacle1.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_17;
            this.houseObstacle1.Location = new System.Drawing.Point(1104, 120);
            this.houseObstacle1.Name = "houseObstacle1";
            this.houseObstacle1.Size = new System.Drawing.Size(115, 150);
            this.houseObstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.houseObstacle1.TabIndex = 10;
            this.houseObstacle1.TabStop = false;
            this.houseObstacle1.Click += new System.EventHandler(this.houseObstacle1_Click);
            // 
            // houseObstacle2
            // 
            this.houseObstacle2.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.houseObstacle2.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_18;
            this.houseObstacle2.Location = new System.Drawing.Point(159, 331);
            this.houseObstacle2.Name = "houseObstacle2";
            this.houseObstacle2.Size = new System.Drawing.Size(117, 118);
            this.houseObstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.houseObstacle2.TabIndex = 11;
            this.houseObstacle2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.player1.Location = new System.Drawing.Point(531, 181);
            this.player1.Margin = new System.Windows.Forms.Padding(4);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(54, 73);
            this.player1.TabIndex = 0;
            this.player1.Load += new System.EventHandler(this.player1_Load);
            // 
            // botGatherer1
            // 
            this.botGatherer1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.botGatherer1.Location = new System.Drawing.Point(942, 280);
            this.botGatherer1.Margin = new System.Windows.Forms.Padding(4);
            this.botGatherer1.Name = "botGatherer1";
            this.botGatherer1.Size = new System.Drawing.Size(60, 69);
            this.botGatherer1.TabIndex = 6;
            // 
            // bushObstacle3
            // 
            this.bushObstacle3.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.bushObstacle3.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_19;
            this.bushObstacle3.Location = new System.Drawing.Point(1074, 358);
            this.bushObstacle3.Name = "bushObstacle3";
            this.bushObstacle3.Size = new System.Drawing.Size(51, 63);
            this.bushObstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bushObstacle3.TabIndex = 12;
            this.bushObstacle3.TabStop = false;
            // 
            // bushObstacle1
            // 
            this.bushObstacle1.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.bushObstacle1.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_19;
            this.bushObstacle1.Location = new System.Drawing.Point(119, 95);
            this.bushObstacle1.Name = "bushObstacle1";
            this.bushObstacle1.Size = new System.Drawing.Size(51, 63);
            this.bushObstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bushObstacle1.TabIndex = 13;
            this.bushObstacle1.TabStop = false;
            // 
            // bushObstacle4
            // 
            this.bushObstacle4.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.bushObstacle4.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_19;
            this.bushObstacle4.Location = new System.Drawing.Point(886, 42);
            this.bushObstacle4.Name = "bushObstacle4";
            this.bushObstacle4.Size = new System.Drawing.Size(51, 63);
            this.bushObstacle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bushObstacle4.TabIndex = 14;
            this.bushObstacle4.TabStop = false;
            // 
            // bushObstacle2
            // 
            this.bushObstacle2.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.bushObstacle2.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_19;
            this.bushObstacle2.Location = new System.Drawing.Point(458, 453);
            this.bushObstacle2.Name = "bushObstacle2";
            this.bushObstacle2.Size = new System.Drawing.Size(51, 63);
            this.bushObstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bushObstacle2.TabIndex = 15;
            this.bushObstacle2.TabStop = false;
            // 
            // houseObstacle3
            // 
            this.houseObstacle3.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.houseObstacle3.Image = global::NomadGameAgain.Properties.Resources.medievalStructure_19;
            this.houseObstacle3.Location = new System.Drawing.Point(335, 21);
            this.houseObstacle3.Name = "houseObstacle3";
            this.houseObstacle3.Size = new System.Drawing.Size(130, 137);
            this.houseObstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.houseObstacle3.TabIndex = 16;
            this.houseObstacle3.TabStop = false;
            // 
            // logObstacle
            // 
            this.logObstacle.BackgroundImage = global::NomadGameAgain.Properties.Resources.medievalTile_13;
            this.logObstacle.Image = global::NomadGameAgain.Properties.Resources.medievalEnvironment_05;
            this.logObstacle.Location = new System.Drawing.Point(823, 466);
            this.logObstacle.Name = "logObstacle";
            this.logObstacle.Size = new System.Drawing.Size(100, 50);
            this.logObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logObstacle.TabIndex = 17;
            this.logObstacle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 567);
            this.Controls.Add(this.logObstacle);
            this.Controls.Add(this.houseObstacle3);
            this.Controls.Add(this.bushObstacle2);
            this.Controls.Add(this.bushObstacle4);
            this.Controls.Add(this.bushObstacle1);
            this.Controls.Add(this.bushObstacle3);
            this.Controls.Add(this.houseObstacle2);
            this.Controls.Add(this.houseObstacle1);
            this.Controls.Add(this.obstacleCenter);
            this.Controls.Add(this.labelCoinsLeft);
            this.Controls.Add(this.labelCoinsGathered);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.botGatherer1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseObstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseObstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushObstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushObstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushObstacle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushObstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseObstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logObstacle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameObjects.Player player1;
        private System.Windows.Forms.Timer timerCoins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerUpdate;
        private GameObjects.BotGatherer botGatherer1;
        private System.Windows.Forms.Label labelCoinsGathered;
        private System.Windows.Forms.Label labelCoinsLeft;
        private System.Windows.Forms.PictureBox obstacleCenter;
        private System.Windows.Forms.PictureBox houseObstacle1;
        private System.Windows.Forms.PictureBox houseObstacle2;
        private System.Windows.Forms.PictureBox bushObstacle3;
        private System.Windows.Forms.PictureBox bushObstacle1;
        private System.Windows.Forms.PictureBox bushObstacle4;
        private System.Windows.Forms.PictureBox bushObstacle2;
        private System.Windows.Forms.PictureBox houseObstacle3;
        private System.Windows.Forms.PictureBox logObstacle;
    }
}

