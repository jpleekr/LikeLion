using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
			/*int[] iArray = new int[25];
			int input = 0;
			int iBingo = 0;
			int iCount = 0;
			Random rand = new Random();

			for (int i = 0; i < iArray.Length; i++)
            {
                iArray[i] = i + 1;
            }

			for (int i = 0; i < 100; i++)
			{
				int iA = rand.Next(0, 25);
				int iB = rand.Next(0, 25);
				int iT = 0;


				iT = iArray[iA];
				iArray[iA] = iArray[iB];
				iArray[iB] = iT;
			}

			while (true)
			{
				Console.Clear();

				for (int i = 0; i < 5; i++)
				{
					for (int j = 0; j < 5; j++)
					{
						if (iArray[i * 5 + j] == 0)
						{
							Console.Write(" * ");
						}
						else
						{
							Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
						}
					}
					Console.WriteLine();
				}

				Console.WriteLine("빙고 갯수 : " + iBingo);
				Console.Write("숫자를 입력하세요 : ");
				input = int.Parse(Console.ReadLine());
				iBingo = 0;

				for (int i = 0; i < iArray.Length; i++)
				{
					if (iArray[i] == input)
					{
						iArray[i] = 0;
						break;
					}
				}

				for (int i = 0; i < 5; i++)
				{
					for (int j = 0; j < 5; j++)
					{
						if (iArray[i * 5 + j] == 0)
						{
							iCount++;
						}

						if (iCount == 5)
						{
							iBingo++;
						}
					}
					iCount = 0;
				}

				for (int i = 0; i < 5; i++)
				{
					for (int j = 0; j < 5; j++)
					{
						if (iArray[i + j * 5] == 0)
						{
							iCount++;
						}

						if (iCount == 5)
						{
							iBingo++;
						}

					}
					iCount = 0;
				}

				for (int i = 0; i < 5; i++)
				{
					if(iArray[ i * 4 + 4] == 0)
					{
						iCount++;
					}

					if (iCount == 5)
					{
						iBingo++;
					}
				}

				iCount = 0;

				for (int i = 0; i < 5; i++)
				{
					if (iArray[i * 6] == 0)
					{
						iCount++;
					}

					if (iCount == 5)
					{
						iBingo++;
					}
				}

				iCount = 0;

				if (iBingo >= 5)
				{
					Console.WriteLine("빙고 성공");
					break;
				}
			}*/

			int[,] board = new int[5, 5];
			bool[,] marked = new bool[5, 5];
			int[] numbers = new int[25];

			Random random = new Random();

			int index = 0;
			int bingoCount = 0;
			bool found = false;
			bool diag1Bingo = true;
			bool diag2Bingo = true;

			for (int i = 0; i < 25; i++)
				numbers[i] = i + 1;

			for(int i = 0; i < 100; i++)
			{
				int a = random.Next(25);
				int b = random.Next(25);

				(numbers[a], numbers[b]) = (numbers[b], numbers[a]);
			}

			for(int i = 0; i < 5; i++)
			{
				for(int j =0; j < 5; j++)
				{
					board[i, j] = numbers[index++];
				}
			}

			while (bingoCount < 5)
			{
				Console.Clear();
				Console.WriteLine("현재 빙고판");

				for (int i = 0; i < 5; i++)
				{
					for (int j = 0; j < 5; j++)
					{
						if (marked[i, j]) Console.Write(" X ");
						else Console.Write($"{board[i, j],2} ");
					}
					Console.WriteLine();
				}

				Console.WriteLine($"현재 빙고 갯수 : {bingoCount}");
				Console.WriteLine("숫자를 입력하세요 (1~25) : ");
				int number = int.Parse(Console.ReadLine());

				/*if (int.TryParse(Console.ReadLine(), out int number))
				{

				}*/

				for (int i = 0; i < 5; i++)
				{
					for (int j = 0; j < 5; j++)
					{
						if (board[i, j] == number)
						{
							marked[i, j] = true;
							found = true;
							break;
						}
						if (found)
							break;
					}
				}

				found = false;
				bingoCount = 0;

				for(int i = 0; i < 5; i++)
				{
					bool rowBingo = true;
					for(int j = 0; j < 5; j++)
					{
						if (!marked[i, j]) rowBingo = false;
					}

					if (rowBingo) bingoCount++;
				}

				for (int i = 0; i < 5; i++)
				{
					bool colwBingo = true;
					for (int j = 0; j < 5; j++)
					{
						if (!marked[j, i]) colwBingo = false;
					}

					if (colwBingo) bingoCount++;
				}

				diag1Bingo = true;

				for(int i = 0; i < 5; i++)
				{
					if (!marked[i, i]) diag1Bingo = false;
				}

				if (diag1Bingo) bingoCount++;

				diag2Bingo = true;

				for (int i = 0; i < 5; i++)
				{
					if (!marked[i, 4 - i]) diag2Bingo = false;
				}

				if (diag2Bingo) bingoCount++;

			}

			Console.Clear();
			Console.WriteLine("빙고 5개 완성! 게임종료");

		}
    }
}
