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
        public int speed = 6;

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

        // Создаем один раз экземпляр Random
        private Random random = new Random();

        private void Coin_Generate(object sender, EventArgs e)
        {
            Console.WriteLine("Generating coin...");

            // Генерируем уникальные координаты для каждой монетки
            var x = random.Next(20, 300);
            var y = random.Next(20, 300);

            Coin coin = new Coin(x, y);
            Console.WriteLine($"Coin created at position ({x}, {y})");

            // Добавляем монетку на форму
            Controls.Add(coin);
            Console.WriteLine("Coin added to controls");

            // Добавляем монетку в список монет
            Core.CoinsList.Add(coin);
            Console.WriteLine($"Total coins: {Core.CoinsList.Count}");

            // Обновляем текст метки
            labelCoinsLeft.Text = $"{Core.CoinsList.Count} Left";

            // Обновляем экран
            Invalidate();
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

            if ((player1.Bounds.IntersectsWith(obstacleCenter.Bounds)) || (player1.Bounds.IntersectsWith(houseObstacle1.Bounds)) ||
                (player1.Bounds.IntersectsWith(houseObstacle2.Bounds)) || (player1.Bounds.IntersectsWith(houseObstacle3.Bounds)) ||
                (player1.Bounds.IntersectsWith(labelCoinsGathered.Bounds)) || (player1.Bounds.IntersectsWith(labelCoinsLeft.Bounds)) ||
                (player1.Bounds.IntersectsWith(bushObstacle1.Bounds)) || (player1.Bounds.IntersectsWith(bushObstacle2.Bounds)) ||
                (player1.Bounds.IntersectsWith(bushObstacle3.Bounds)) || (player1.Bounds.IntersectsWith(bushObstacle4.Bounds)) ||
                 (player1.Bounds.IntersectsWith(logObstacle.Bounds)))

            {
                if (Core.IsRight)
                {
                    Core.IsRight = false;
                    player1.Left -= speed; // Откатываем игрока назад, чтобы он не застрял в препятствии
                }

                // То же самое делаем для остальных направлений движения
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
            {
                if (Core.IsRight)
                {
                    Core.IsRight = false;
                    player1.Left -= speed; // Откатываем игрока назад, чтобы он не застрял в препятствии
                }

                // То же самое делаем для остальных направлений движения
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
        }

        private void coin1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void houseObstacle1_Click(object sender, EventArgs e)
        {

        }

        private void houseObstacle3_Click(object sender, EventArgs e)
        {

        }

        void AddCoin()
        {
            Core.Coins++;
            labelCoinsGathered.Text = $"{Core.Coins} Coins";
        }
    }
}
