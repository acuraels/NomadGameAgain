using NomadGameAgain.GameObjects;
using System;
using System.Collections.Generic;

namespace NomadGameAgain
{
    public class GameController
    {
        private Player player;
        private BotGatherer bot;
        private List<Coin> coins;

        public GameController(Player player, BotGatherer bot, List<Coin> coins)
        {
            this.player = player;
            this.bot = bot;
            this.coins = coins;

            // Дополнительная инициализация, если необходимо
            Initialize();
        }

        private void Initialize()
        {
            // Дополнительная инициализация контроллера, если необходимо
        }

        public void StartGame()
        {
            // Метод для начала игры
            // Например, можно вызвать методы начала работы игрока, бота и монет
            // player.Start();
            // bot.Start();
            // foreach (var coin in coins)
            // {
            //     coin.Start();
            // }
        }

        // Другие методы управления игрой...
    }
}
