using NomadGameAgain.GameObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NomadGameAgain
{
    public class GameController
    {
        private Player player;
        private BotGatherer bot;
        private List<Coin> coins;
        private Timer gameTimer;

        public GameController(Player player, BotGatherer bot, List<Coin> coins)
        {
            this.player = player;
            this.bot = bot;
            this.coins = coins;

            Initialize();
        }

        private void Initialize()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 100; 
            gameTimer.Tick += Update;
        }

        private void Update(object sender, EventArgs e)
        {
            UpdatePlayer();
            UpdateBot();

            foreach (var coin in coins)
                coin.Update();

            Initialize();
        }

        private void UpdatePlayer()
        {
            Initialize();
        }

        private void UpdateBot()
        {
            Initialize();
        }
    }
}
