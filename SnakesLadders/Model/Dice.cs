using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame.Model
{
    public class Dice
    {
        private static   int sides { get; set; } = Constants.MaxDiceSides;
        public static int RollDice()
        {
            Random rnd = new Random();
            return rnd.Next(1, sides + 1);
        }
    }
}
