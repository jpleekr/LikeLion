using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(130, 40);
            Console.SetWindowSize(130, 40);
			Console.CursorVisible = false;
            

            Dice[] arrDice = new Dice[5];
            ScoreBoard board = new ScoreBoard();
            Draw draw = new Draw();
            KeyEvent keyEvent = new KeyEvent();

			int nRerollNum = 0/*리롤횟수*/ , nRoundNum = 0/*라운드수*/, nIndex = 0/*인덱스*/, nTotalScore = 0;/*총점*/

            Console.Clear();

            for(int i = 0; i < 5; i++)
            {
                arrDice[i] = new Dice();
            }

            Dice.InitDice(ref arrDice);//주사위 초기화

			draw.DrawBoard(ref board);//보드 그리기

            while (true)
            {
                draw.SetScore(ref board);
				Dice.DiceRoll(ref arrDice);
                draw.DrawDiceRoll(ref arrDice);
                draw.SelectDice(ref nIndex, false);
                nRerollNum++;

                while (true)
                {
                    if (nRerollNum < 3)
                    {
                        if (keyEvent.DiceKeyEvent(ref draw,ref arrDice, ref nIndex, ref nRerollNum))
                        {
							Dice.DiceRoll(ref arrDice);
							draw.DrawDiceRoll(ref arrDice);
							nRerollNum++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            arrDice[i].bReroll = false;
                        }
                        draw.DrawDice(ref arrDice);
                        nRerollNum = 0;
                        break;
                    }
                }

                ScoreBoard.ScoreOutput(ref arrDice, ref board);
                nIndex = 0;
				draw.SetScore(ref board);
				draw.SelectDice(ref nIndex, false);

				while (true)
				{
					if (keyEvent.ScoreKeyEvent(ref draw ,ref board,ref nIndex))
						break;
				}

                Dice.InitDice(ref arrDice);
				nIndex = 0;
				nRoundNum++;
				if (nRoundNum > 11)
					break;

			}

			nTotalScore = ScoreBoard.GetTotalScore(board);

            Console.Clear();

            draw.WriteXY(30, 10, "===========================gameset===========================\n\n");
            draw.WriteXY(54, 15, $"최종점수 = {nTotalScore}/n\n\n\n\n\n\n\n\n\n\n\n");
            draw.WriteXY(30, 20, "==============================================================\n\n");

			Console.CursorVisible = true;
			Console.ReadLine();
		}
    }
}
