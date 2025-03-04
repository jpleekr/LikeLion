using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtDice
{
    public class Dice
    {
		public int nDiceNum = 0;
        public bool bReroll = true;

        static Random rand = new Random(Guid.NewGuid().GetHashCode());

        static public void InitDice(ref Dice[] dice)
        {
            for(int i = 0; i < dice.Length; i++)
            {
                dice[i].nDiceNum = 0;
                dice[i].bReroll = true;
            }
        }

        static public void DiceRoll(ref Dice[] dice)
        {
			for (int i = 0; i < dice.Length; i++)
			{
				if (dice[i].bReroll)
				{
					dice[i].nDiceNum = rand.Next(1, 7);
				}
			}
		}
    }
}
