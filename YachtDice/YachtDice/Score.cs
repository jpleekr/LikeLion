using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtDice
{
    public class Score
    {
        private int nScore;
		private bool bReset;
    }

    public class ScoreBoard
    {
		private Score Aces;
		private Score Twos;
		private Score Threes;
		private Score Fours;
		private Score Fives;
		private Score Sixes;
		private Score Choice;
		private Score FourOfKind;
		private Score FullHouse;
		private Score S_Straight;
		private Score L_Straight;
		private Score Yachu;
		private int nBouns;
    }
}