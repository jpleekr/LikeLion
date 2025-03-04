using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YachtDice
{
	public class Draw
	{
		public const int WIDTH = 22;
		public const int DX = 2;
		public const int DY = 2;
		public const int PADDINGX = 42;
		public const int PADDINGY = 13;

		Random rand = new Random(Guid.NewGuid().GetHashCode());

		string[] arTile = new string[7] { "  ", "◇", "□", "■", "*", "--", "<-" };
		int[,,] arDice = new int[6,10,9]
		{
			{
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 1, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			},
			{
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 1, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 1, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			},
			{
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 1, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 1, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 1, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			},
			{
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 1, 0, 0, 0, 1, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 1, 0, 0, 0, 1, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			},
			{
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 1, 0, 0, 0, 1, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 1, 0, 0, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 1, 0, 0, 0, 1, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }

			},
			{
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 1, 0, 0, 0, 1, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 1, 0, 0, 0, 1, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 0, 1, 0, 0, 0, 1, 0, 3 },
				{ 3, 0, 0, 0, 0, 0, 0, 0, 3 },
				{ 3, 3, 3, 3, 3, 3, 3, 3, 3 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			}
		};

		int[,,] arSelectDice = new int[6,10,9]
		{
			{
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 1, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			},
			{
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 1, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 1, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			},
			{
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 1, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 1, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 1, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			},
			{
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 1, 0, 0, 0, 1, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 1, 0, 0, 0, 1, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			},
			{
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 1, 0, 0, 0, 1, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 1, 0, 0, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 1, 0, 0, 0, 1, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }

			},
			{
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 1, 0, 0, 0, 1, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 1, 0, 0, 0, 1, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 0, 1, 0, 0, 0, 1, 0, 2 },
				{ 2, 0, 0, 0, 0, 0, 0, 0, 2 },
				{ 2, 2, 2, 2, 2, 2, 2, 2, 2 },
				{ 0, 0, 0, 0, 0, 0, 0, 0, 0 }
			}
		};

		int[,] arboard = new int[18,20]
		{
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 3, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, 0, 0, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 3, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, 0, 0, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 3, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, 0, 0, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 3, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, 0, 0, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 3, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, 0, 0, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
			{ 3, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, 0, 0, 2 },
			{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 2, 2, 2, 2 },
		};

		int[,,] arScore = new int[2,3,4]
		{ 
			{
				{ 3, 3, 3, 3 },
				{ 3, 0, 0, 3 },
				{ 3, 3, 3, 3 },
			},
			{
				{ 2, 2, 2, 2 },
				{ 2, 0, 0, 2 },
				{ 2, 2, 2, 2 },
			}
		};

		public void WriteXY(int x, int y, string str)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(str);
		}

		public void DrawDice(ref Dice[] dice)
		{
			for (int i = 0; i < 5; i++)
			{
				for (int y = 0; y < 10; y++)
				{
					for (int x = 0; x < 9; x++)
					{
						if (dice[i].bReroll)
						{
							WriteXY(DX + (i * WIDTH) + (x * 2), DY + y,
								arTile[arSelectDice[dice[i].nDiceNum - 1, y, x]]);
						}
						else
						{
							WriteXY(DX + (i * WIDTH) + (x * 2), DY + y,
								arTile[arDice[dice[i].nDiceNum - 1, y, x]]);
						}
					}
				}
			}
		}

		public void SelectDice(ref int index, bool isRight)
		{
			if (isRight)
			{
				for (int x = 0; x < 9; x++)
				{
					WriteXY(DX + ((index - 1) * WIDTH) + (x * 2), DY + 9, arTile[0]);
				}
			}
			else
			{
				for (int x = 0; x < 9; x++)
				{
					WriteXY(DX + ((index + 1) * WIDTH) + (x * 2), DY + 9, arTile[0]);
				}
			}

			Console.ForegroundColor = ConsoleColor.DarkYellow;

			for (int x = 0; x < 9; x++)
			{
				WriteXY(DX + (index * WIDTH) + (x * 2), DY + 9, arTile[4]);
			}

			Console.ForegroundColor = ConsoleColor.Cyan;
		}

		public void DrawBoard(ref ScoreBoard board)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;

			for (int y = 0; y < 18; y++)
			{
				for (int x = 0; x < 20; x++)
				{
					WriteXY(x * 2, PADDINGY + y, arTile[arboard[y, x] - 0]);
				}
			}

			for (int y = 0; y < 18; y++)
			{
				for (int x = 0; x < 20; x++)
				{
					WriteXY(PADDINGX + (x * 2), PADDINGY + y, arTile[arboard[y, x] - 0]);
				}
			}

			Console.ForegroundColor = ConsoleColor.DarkYellow;

			WriteXY(2, PADDINGY + 1, "Aces");
			WriteXY(14, PADDINGY + 1, "'1'에 눈의 합");
			WriteXY(2, PADDINGY + 4, "Twos");
			WriteXY(14, PADDINGY + 4, "'2'에 눈의 합");
			WriteXY(2, PADDINGY + 7, "Threes");
			WriteXY(14, PADDINGY + 7, "'3'에 눈의 합");
			WriteXY(2, PADDINGY + 10, "Fours");
			WriteXY(14, PADDINGY + 10, "'4'에 눈의 합");
			WriteXY(2, PADDINGY + 13, "Fives");
			WriteXY(14, PADDINGY + 13, "'5'에 눈의 합");
			WriteXY(2, PADDINGY + 16, "Sixes");
			WriteXY(14, PADDINGY + 16, "'6'에 눈의 합");
			WriteXY(2, PADDINGY + 18, "* Bouns :");

			WriteXY(PADDINGX + 2, PADDINGY + 1, "Choice");
			WriteXY(PADDINGX + 14, PADDINGY + 1, "모든 눈의 합");
			WriteXY(PADDINGX + 2, PADDINGY + 4, "FourOfKind");
			WriteXY(PADDINGX + 14, PADDINGY + 4, "모든 눈의 합");
			WriteXY(PADDINGX + 2, PADDINGY + 7, "FullHouse");
			WriteXY(PADDINGX + 14, PADDINGY + 7, "모든 눈의 합");
			WriteXY(PADDINGX + 2, PADDINGY + 10, "S_Straight");
			WriteXY(PADDINGX + 14, PADDINGY + 10, "합과 상관없이 15");
			WriteXY(PADDINGX + 2, PADDINGY + 13, "L_Straight");
			WriteXY(PADDINGX + 14, PADDINGY + 13, "합과 상관없이 30");
			WriteXY(PADDINGX + 2, PADDINGY + 16, "Yachu");
			WriteXY(PADDINGX + 14, PADDINGY + 16, "합과 상관없이 50");

			Console.ForegroundColor = ConsoleColor.DarkRed;

			WriteXY(85, 13, "* 주사위 좌우이동");
			WriteXY(85, 14, "* 주사위 아랫방향키 : 고정 및 해제");
			WriteXY(85, 15, "* 주사위 윗방향키  : 주사위 굴리기");
			WriteXY(85, 16, "* 점수판 상하이동");
			WriteXY(85, 17, "* SPACE BAR : 점수 및 주사위 확정");

			WriteXY(95, 19, "* 주사위 조합 조건");
			WriteXY(85, 20, "* Choice : 조건 없음");
			WriteXY(85, 21, "* FourOfKind : 4개에 똑같은 눈");
			WriteXY(85, 22, "* FullHouse : ");
			WriteXY(85, 23, "  3개에 같은눈과 두개에 같은눈");
			WriteXY(85, 24, "* S_Straight : 이어지는 숫자4개");
			WriteXY(85, 25, "* L_Straight : 이어지는 숫자5개");
			WriteXY(85, 26, "* Yachu : 5개에 똑같은 눈");
			WriteXY(85, 27, "* Bouns : 왼쪽점수표 합이");
			WriteXY(85, 28, "* 63이상이면 35점 추가점수");

			WriteXY(85, 30, "* 리롤횟수 : 3번");
			WriteXY(85, 31, "* 종합점수가 높으면면 승리");

			Console.ForegroundColor = ConsoleColor.Cyan;
		}

		public void SelectBoard(ref ScoreBoard board, ref int index, bool isDown)
		{
			int nNum = index;
			nNum = (nNum * 3) / 2;

			if (isDown)
			{
				if (nNum < 21)
				{
					WriteXY(36, PADDINGY - 2 + nNum, arTile[0]);
				}
				else
				{
					WriteXY(PADDINGX + 36, PADDINGY - 20 + nNum, arTile[0]);
				}
			}
			else
			{
				if (nNum > 12)
				{
					WriteXY(PADDINGX + 36, PADDINGY - 14 + nNum, arTile[0]);
				}
				else
				{
					WriteXY(36, PADDINGY + 4 + nNum, arTile[0]);
				}
			}

			Console.ForegroundColor = ConsoleColor.DarkYellow;


			if (nNum < 18)
			{
				WriteXY(36, PADDINGY + 1 + nNum, arTile[6]);
			}
			else
			{
				WriteXY(PADDINGX + 36, PADDINGY - 17 + nNum, arTile[6]);
			}

			Console.ForegroundColor = ConsoleColor.Cyan;
		}

		public void SetScore(ref ScoreBoard board)
		{

			if (!board.Aces.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(32 + (x * 2), PADDINGY + y, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.Twos.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(32 + (x * 2), PADDINGY + y + 3, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.Threes.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(32 + (x * 2), PADDINGY + y + 6, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.Fours.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(32 + (x * 2), PADDINGY + y + 9, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.Fives.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(32 + (x * 2), PADDINGY + y + 12, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.Sixes.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(32 + (x * 2), PADDINGY + y + 15, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.Choice.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(PADDINGX + 32 + (x * 2), PADDINGY + y, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.FourOfKind.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(PADDINGX + 32 + (x * 2), PADDINGY + y + 3, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.FullHouse.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(PADDINGX + 32 + (x * 2), PADDINGY + y + 6, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.S_Straight.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(PADDINGX + 32 + (x * 2), PADDINGY + y + 9, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.L_Straight.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(PADDINGX + 32 + (x * 2), PADDINGY + y + 12, arTile[arScore[0, y, x]]);
					}
				}
			}

			if (!board.Yachu.bReset)
			{
				for (int y = 0; y < 3; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						WriteXY(PADDINGX + 32 + (x * 2), PADDINGY + y + 15, arTile[arScore[0, y, x]]);
					}
				}
			}

			Console.ForegroundColor = ConsoleColor.DarkYellow;

			WriteXY(34, PADDINGY + 1, board.Aces.nScore.ToString());
			WriteXY(34, PADDINGY + 4, board.Twos.nScore.ToString());
			WriteXY(34, PADDINGY + 7, board.Threes.nScore.ToString());
			WriteXY(34, PADDINGY + 10, board.Fours.nScore.ToString());
			WriteXY(34, PADDINGY + 13, board.Fives.nScore.ToString());
			WriteXY(34, PADDINGY + 16, board.Sixes.nScore.ToString());
			WriteXY(PADDINGX + 34, PADDINGY + 1, board.Choice.nScore.ToString());
			WriteXY(PADDINGX + 34, PADDINGY + 4, board.FourOfKind.nScore.ToString());
			WriteXY(PADDINGX + 34, PADDINGY + 7, board.FullHouse.nScore.ToString());
			WriteXY(PADDINGX + 34, PADDINGY + 10, board.S_Straight.nScore.ToString());
			WriteXY(PADDINGX + 34, PADDINGY + 13, board.L_Straight.nScore.ToString());
			WriteXY(PADDINGX + 34, PADDINGY + 16, board.Yachu.nScore.ToString());
			WriteXY(12, PADDINGY + 18, ScoreBoard.GetBouns( board).ToString());

			Console.ForegroundColor = ConsoleColor.Cyan;
		}

		public void DrawDiceRoll(ref Dice[] dice)
		{
			int nRandom = 0;

			for (int i = 0; i < 5; i++)
			{
				if (dice[i].bReroll)
				{
					for (int j = 0; j < 20; j++)
					{
						for (int y = 0; y < 10; y++)
						{
							for (int x = 0; x < 9; x++)
							{
								nRandom = rand.Next(0, 6);
								WriteXY(DX + (i * WIDTH) + (x * 2), DY + y,
									arTile[arSelectDice[nRandom, y, x]]);
							}
						}
						Thread.Sleep(20);
					}

					for (int y = 0; y < 10; y++)
					{
						for (int x = 0; x < 9; x++)
						{

							WriteXY(DX + (i * WIDTH) + (x * 2), DY + y,
								arTile[arSelectDice[dice[i].nDiceNum - 1, y, x]]);



						}
					}
				}
				else
				{
					for (int y = 0; y < 10; y++)
					{
						for (int x = 0; x < 9; x++)
						{
							WriteXY(DX + (i * WIDTH) + (x * 2), DY + y,
								arTile[arDice[dice[i].nDiceNum - 1, y, x]]);
						}
					}
				}
			}
		}

	}
}
