using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtDice
{
    public class Score
    {
		public int nScore;
		public bool bReset;

		public Score()
		{
			nScore = 0;
			bReset = false;
		}
    }

	public class ScoreBoard
	{
		public Score Aces;
		public Score Twos;
		public Score Threes;
		public Score Fours;
		public Score Fives;
		public Score Sixes;
		public Score Choice;
		public Score FourOfKind;
		public Score FullHouse;
		public Score S_Straight;
		public Score L_Straight;
		public Score Yachu;
		public int nBouns;

		public ScoreBoard()
		{
			Aces = new Score();
			Twos = new Score();
			Threes = new Score();
			Fours = new Score();
			Fives = new Score();
			Sixes = new Score();
			Choice = new Score();
			FourOfKind = new Score();
			FullHouse = new Score();
			S_Straight = new Score();
			L_Straight = new Score();
			Yachu = new Score();
		}


		static public int GetBouns(ScoreBoard board)
		{
			int nSum = 0;

			if (board.nBouns == 0)
			{
				if (board.Aces.bReset)
					nSum += board.Aces.nScore;

				if (board.Twos.bReset)
					nSum += board.Twos.nScore;

				if (board.Threes.bReset)
					nSum += board.Threes.nScore;

				if (board.Fours.bReset)
					nSum += board.Fours.nScore;

				if (board.Fives.bReset)
					nSum += board.Fives.nScore;

				if (board.Sixes.bReset)
					nSum += board.Sixes.nScore;

			}

			return nSum;
		}

		static public void ScoreOutput(ref Dice[] dice, ref ScoreBoard board)
		{
			int i, j;
			int nSum = 0;
			int[] TotalNum = new int[6];

			for (i = 0; i < 5; i++)
			{
				if (dice[i].nDiceNum == 1)
					TotalNum[0]++;

				else if (dice[i].nDiceNum == 2)
					TotalNum[1]++;

				else if (dice[i].nDiceNum == 3)
					TotalNum[2]++;

				else if (dice[i].nDiceNum == 4)
					TotalNum[3]++;

				else if (dice[i].nDiceNum == 5)
					TotalNum[4]++;

				else if (dice[i].nDiceNum == 6)
					TotalNum[5]++;
			}

			if (!board.Aces.bReset)
				board.Aces.nScore = 1 * TotalNum[0];
			if (!board.Twos.bReset)
				board.Twos.nScore = 2 * TotalNum[1];
			if (!board.Threes.bReset)
				board.Threes.nScore = 3 * TotalNum[2];
			if (!board.Fours.bReset)
				board.Fours.nScore = 4 * TotalNum[3];
			if (!board.Fives.bReset)
				board.Fives.nScore = 5 * TotalNum[4];
			if (!board.Sixes.bReset)
				board.Sixes.nScore = 6 * TotalNum[5];

			for (i = 0; i < 6; i++)
			{
				nSum += (i + 1) * TotalNum[i];
			}

			if (!board.Choice.bReset)
				board.Choice.nScore = nSum;

			if (!board.FourOfKind.bReset)
			{
				for (i = 0; i < 6; i++)
				{
					if (TotalNum[i] == 4)
					{
						board.FourOfKind.nScore = nSum;
						break;
					}
				}
			}

			if (!board.FullHouse.bReset)
			{
				for (i = 0; i < 6; i++)
				{
					if (TotalNum[i] == 3)
					{
						for (j = 0; j < 6; j++)
						{
							if (TotalNum[j] == 2)
							{
								board.FullHouse.nScore = nSum;
								break;
							}
						}
					}
				}
			}

			if (!board.S_Straight.bReset)
			{
				if (TotalNum[0] > 0 && TotalNum[1] > 0 && TotalNum[2] > 0 && TotalNum[3] > 0)
				{
					board.S_Straight.nScore = 15;
				}
				else if (TotalNum[1] > 0 && TotalNum[2] > 0 && TotalNum[3] > 0 && TotalNum[4] > 0)
				{
					board.S_Straight.nScore = 15;
				}
				else if (TotalNum[2] > 0 && TotalNum[3] > 0 && TotalNum[4] > 0 && TotalNum[5] > 0)
				{
					board.S_Straight.nScore = 15;
				}
			}

			if (!board.L_Straight.bReset)
			{
				if (TotalNum[0] == 1 && TotalNum[1] == 1 && TotalNum[2] == 1 && TotalNum[3] == 1 && TotalNum[4] == 1)
				{
					board.L_Straight.nScore = 30;
				}
				else if (TotalNum[1] == 1 && TotalNum[2] == 1 && TotalNum[3] == 1 && TotalNum[4] == 1 && TotalNum[5] == 1)
				{
					board.L_Straight.nScore = 30;
				}
			}

			if (!board.Yachu.bReset)
			{
				for (i = 0; i < 6; i++)
				{
					if (TotalNum[i] == 5)
					{
						board.Yachu.nScore = 50;
						break;
					}
				}
			}

			if (board.nBouns == 0)
			{
				nSum = 0;

				if (board.Aces.bReset)
					nSum += board.Aces.nScore;

				if (board.Twos.bReset)
					nSum += board.Twos.nScore;

				if (board.Threes.bReset)
					nSum += board.Threes.nScore;

				if (board.Fours.bReset)
					nSum += board.Fours.nScore;

				if (board.Fives.bReset)
					nSum += board.Fives.nScore;

				if (board.Sixes.bReset)
					nSum += board.Sixes.nScore;

			}
			if (GetBouns(board) >= 63)
				board.nBouns = 35;
		}

		static public int GetTotalScore(ScoreBoard board)
		{
			int nSum = 0;

			nSum = board.Aces.nScore + board.Twos.nScore + board.Threes.nScore + board.Fours.nScore + board.Fives.nScore
				+ board.Sixes.nScore + board.Choice.nScore + board.FourOfKind.nScore + board.FullHouse.nScore + board.S_Straight.nScore
				+ board.L_Straight.nScore + board.Yachu.nScore + board.nBouns;

			return nSum;
		}
    }
}