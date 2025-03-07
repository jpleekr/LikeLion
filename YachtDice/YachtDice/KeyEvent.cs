﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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

		[DllImport("msvcrt.dll")]
		static extern int _getch();

        public bool DiceKeyEvent(ref Draw draw,ref Dice[] dices,  ref int index, ref int count )
        {

			int ch = 0;
			draw.SelectDice(ref index, false);

			ch = _getch();
			if (ch == 0xE0 || ch == 0)
			{
				ch = _getch();

				switch (ch)
				{
					case LEFT:
						index -= 1;
						if (index < 0)
							index = 0;
						draw.SelectDice(ref index, false);
						break;

					case RIGHT:
						index += 1;
						if (index > 4)
							index = 4;
						draw.SelectDice(ref index, true);
						break;

					case DOWN:
						dices[index].bReroll = !dices[index].bReroll;
						draw.DrawDice(ref dices);
						break;

					case UP:
						index = 0;
						return true;


				}
			}
			else
			{
				if (ch == SPACE)
				{
					count = 3;
				}
			}

			return false;
		}

        public bool ScoreKeyEvent(ref Draw draw, ref ScoreBoard board, ref int index)
        {
			int ch;

			ch = _getch();

			if (ch == 0xE0 || ch == 0)
			{
				ch = _getch();

				switch (ch)
				{
					case DOWN:
						index += 2;
						if (index > 22)
							index = 22;
						draw.SelectBoard(ref board, ref index, true);
						break;

					case UP:
						index -= 2;
						if (index < 0)
							index = 0;
						draw.SelectBoard(ref board, ref index, false);
						break;

				}
			}
			else
			{
				if (ch == SPACE)
				{
					bool isRight = false;

					switch (index / 2)
					{
						case 0:
							if (board.Aces.bReset)
							{
								isRight = true;
								break;
							}
							board.Aces.bReset = true;
							break;
						case 1:
							if (board.Twos.bReset)
							{
								isRight = true;
								break;
							}
							board.Twos.bReset = true;
							break;
						case 2:
							if (board.Threes.bReset)
							{
								isRight = true;
								break;
							}
							board.Threes.bReset = true;
							break;
						case 3:
							if (board.Fours.bReset)
							{
								isRight = true;
								break;
							}
							board.Fours.bReset = true;
							break;
						case 4:
							if (board.Fives.bReset)
							{
								isRight = true;
								break;
							}
							board.Fives.bReset = true;
							break;
						case 5:
							if (board.Sixes.bReset)
							{
								isRight = true;
								break;
							}
							board.Sixes.bReset = true;
							break;
						case 6:
							if (board.Choice.bReset)
							{
								isRight = true;
								break;
							}
							board.Choice.bReset = true;
							break;
						case 7:
							if (board.FourOfKind.bReset)
							{
								isRight = true;
								break;
							}
							board.FourOfKind.bReset = true;
							break;
						case 8:
							if (board.FullHouse.bReset)
							{
								isRight = true;
								break;
							}
							board.FullHouse.bReset = true;
							break;
						case 9:
							if (board.S_Straight.bReset)
							{
								isRight = true;
								break;
							}
							board.S_Straight.bReset = true;
							break;
						case 10:
							if (board.L_Straight.bReset)
							{
								isRight = true;
								break;
							}
							board.L_Straight.bReset = true;
							break;
						case 11:
							if (board.Yachu.bReset)
							{
								isRight = true;
								break;
							}
							board.Yachu.bReset = true;
							break;
						default:
							break;

					}

					if(!isRight)
					{

						if (!board.Aces.bReset)
							board.Aces.nScore = 0;
						if (!board.Twos.bReset)
							board.Twos.nScore = 0;
						if (!board.Threes.bReset)
							board.Threes.nScore = 0;
						if (!board.Fours.bReset)
							board.Fours.nScore = 0;
						if (!board.Fives.bReset)
							board.Fives.nScore = 0;
						if (!board.Sixes.bReset)
							board.Sixes.nScore = 0;
						if (!board.Choice.bReset)
							board.Choice.nScore = 0;
						if (!board.FourOfKind.bReset)
							board.FourOfKind.nScore = 0;
						if (!board.FullHouse.bReset)
							board.FullHouse.nScore = 0;
						if (!board.S_Straight.bReset)
							board.S_Straight.nScore = 0;
						if (!board.L_Straight.bReset)
							board.L_Straight.nScore = 0;
						if (!board.Yachu.bReset)
							board.Yachu.nScore = 0;

						return true;
					}
				}
			}

			return false;
        }
    }
}
