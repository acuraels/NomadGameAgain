using NomadGameAgain.GameObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace NomadGameAgain
{
    public partial class Form1 : Form
    {
        private GameController gameController;

        public Form1()
        {
            InitializeComponent();

            // Создаем экземпляры игрока, бота и списка монет
            Player player = new Player();
            BotGatherer bot = new BotGatherer();
            List<Coin> coins = new List<Coin>();

            // Добавляем игрока, бота и монеты на форму и в список монет
            this.Controls.Add(player);
            this.Controls.Add(bot);
            foreach (var coin in coins)
            {
                this.Controls.Add(coin);
            }

            // Создаем экземпляр контроллера и передаем ему игрока, бота и список монет
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
                this.Location = new Point(currentPoint.X - position.X, currentPoint.Y - position.Y + pictureBox1.Top);
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

        private void player1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void Coin_Generate(object sender, EventArgs e)
        {
            Random r = new Random();

            var x = r.Next(20, 300);
            var y = r.Next(20, 300);

            Coin c = new Coin(x, y);
            Controls.Add(c);

            Core.CoinsList.Add(c);

            labelCoinsLeft.Text = $"{Core.CoinsList.Count} Left";
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void Update(object sender, EventArgs e)
        {
            List<Coin> coinsToRemove = new List<Coin>(Core.CoinsList);

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
        }

        private void coin1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        void AddCoin()
        {
            Core.Coins++;
            labelCoinsGathered.Text = $"{Core.Coins} Coins";
        }
    }
}
