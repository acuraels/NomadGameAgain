using NomadGameAgain.GameObjects;
using NomadGameAgain.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NomadGameAgain
{
    public partial class Form1 : Form
    {
        private GameController gameController;
        public int speed = 6;
        private bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();

            Player player = new Player();
            BotGatherer bot = new BotGatherer();
            List<Coin> coins = new List<Coin>();

            this.Controls.Add(player);
            this.Controls.Add(bot);
            foreach (var coin in coins)
                this.Controls.Add(coin);

            gameController = new GameController(player, bot, coins);
        }

        private Point position;
        private bool dragging, lose = false;

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            position.X = e.X;
            position.Y = e.Y;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currentPoint.X - position.X, currentPoint.Y - position.Y + background.Top);
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = true;
            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = true;
            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = true;
            if (e.KeyCode == Core.KeyRight)
                Core.IsRight = true;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = false;
            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = false;
            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = false;
            if (e.KeyCode == Core.KeyRight)
                Core.IsRight = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private Random random = new Random();

        private void Coin_Generate(object sender, EventArgs e)
        {
            var x = random.Next(100, 800);
            var y = random.Next(100, 400);

            Coin coin = new Coin(x, y);

            Controls.Add(coin);

            Core.CoinsList.Add(coin);

            labelCoinsLeft.Text = $"{Core.CoinsList.Count} Left";

            Invalidate();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void Update(object sender, EventArgs e)
        {
            if (isGameOver) return;

            var coinsToRemove = new List<Coin>(Core.CoinsList);

            foreach (var coin in coinsToRemove)
            {
                foreach (var unit in Controls.OfType<Unit>())
                {
                    if (unit.Bounds.IntersectsWith(coin.Bounds))
                    {
                        Core.CoinsList.Remove(coin);
                        Controls.Remove(coin);
                        AddCoin();
                        break;
                    }
                }
            }

            if ((player1.Bounds.IntersectsWith(obstacleCenter.Bounds)) || (player1.Bounds.IntersectsWith(houseObstacle1.Bounds)) ||
                (player1.Bounds.IntersectsWith(houseObstacle2.Bounds)) || (player1.Bounds.IntersectsWith(houseObstacle3.Bounds)) ||
                (player1.Bounds.IntersectsWith(labelCoinsGathered.Bounds)) || (player1.Bounds.IntersectsWith(labelCoinsLeft.Bounds)) ||
                (player1.Bounds.IntersectsWith(bushObstacle1.Bounds)) || (player1.Bounds.IntersectsWith(bushObstacle2.Bounds)) ||
                (player1.Bounds.IntersectsWith(bushObstacle3.Bounds)) || (player1.Bounds.IntersectsWith(bushObstacle4.Bounds)) ||
                (player1.Bounds.IntersectsWith(bushObstacle5.Bounds)) || (player1.Bounds.IntersectsWith(rockObstacle1.Bounds)) ||
                (player1.Bounds.IntersectsWith(rockObstacle2.Bounds)) ||(player1.Bounds.IntersectsWith(pictureBoxTitle.Bounds)) ||
                (player1.Bounds.IntersectsWith(pictureBoxEsc.Bounds)) || (player1.Bounds.IntersectsWith(logObstacle.Bounds)))
            {
                if (Core.IsRight)
                {
                    Core.IsRight = false;
                    player1.Left -= speed;
                }

                if (Core.IsLeft)
                {
                    Core.IsLeft = false;
                    player1.Left += speed;
                }

                if (Core.IsUp)
                {
                    Core.IsUp = false;
                    player1.Top += speed;
                }

                if (Core.IsDown)
                {
                    Core.IsDown = false;
                    player1.Top -= speed;
                }
            }

            if (player1.Bounds.IntersectsWith(botGatherer1.Bounds))
                ShowLoseForm();
        }

        private void ShowLoseForm()
        {
            isGameOver = true;
         
            var loseForm = new LoseForm();
            var result = loseForm.ShowDialog();

            if (result == DialogResult.Retry)
                Application.Restart();
            else if (result == DialogResult.Abort)
                Application.Exit();
        }

        void AddCoin()
        {
            Core.Coins++;
            labelCoinsGathered.Text = $"{Core.Coins} Coins";
        }
    }
}
