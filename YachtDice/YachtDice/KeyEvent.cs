using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtDice
{
    class KeyEvent
    {
        public const int ESC = 27;
        public const int UP = 72;
        public const int DOWN = 80;
        public const int LEFT = 75;
        public const int RIGHT = 77;
        public const int SPACE = 32;

        public bool DiceKeyEvent(ref Dice dice, ref int index, ref int count )
        {
            return true;
        }
    }
}
