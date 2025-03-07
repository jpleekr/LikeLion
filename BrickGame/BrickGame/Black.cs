using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Black
    {
        const int ABLEX = 76;
        const int ABLEY = 16;

        public bool[,] BlackLocation = null;
        public int[] arrRand = null;


		public Black()
        {
            BlackLocation = new bool[ABLEY, ABLEX];
			arrRand = new int[10];

		}


		public void Init()
        {
			Random rand = new Random();

            int randNum = 0;

            for (int i = 0; i < arrRand.Length; i++)
            {
                randNum = rand.Next(0, ABLEX * ABLEY);

                if (arrRand.Contains(randNum))
                {
                    i--;
                }
                // 랜덤 값이 배열에 없으면 배열에 추가
                else
                {
                    arrRand[i] = randNum;
                }
            }

            for (int y = 0; y < ABLEY; y++)
            {
                for(int x = 0; x < ABLEX; x++)
                {
                    if (arrRand.Contains((y * ABLEX) + x))
                    {
                        BlackLocation[y, x] = true;
                    }
                    else
                    {
						BlackLocation[y, x] = false;
					}
                }
            }

        }

        public void DrawBlack()
        {
            for (int y = 0; y < ABLEY; y++)
            {
                for (int x = 0; x < ABLEX; x++)
                {
                    if (BlackLocation[y, x])
                    {
                        Program.gotoxy(x + 1, y + 1);
                        Console.Write("▥");
                    }
                }
            }
        }
	}
}
