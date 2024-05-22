using NomadGameAgain.GameObjects;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NomadGameAgain
{
    public static class Core
    {
        // Keys
        public readonly static Keys KeyUp = Keys.W;
        public readonly static Keys KeyDown = Keys.S;
        public readonly static Keys KeyLeft = Keys.A;
        public readonly static Keys KeyRight = Keys.D;


        // Movement
        public static bool IsUp = false;
        public static bool IsDown = false;
        public static bool IsLeft = false;
        public static bool IsRight = false;


        // Coins
        public static List<Coin> CoinsList = new List<Coin>();
        public static int Coins = 0;
    }
}
