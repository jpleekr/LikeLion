using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔좌표배우기
{
    class Program
    {
        static void EdgeDraw()
        {
			char[] arrChar = new char[80];

			Console.Clear();

			for (int i = 0; i < 25; i++)
			{
				switch (i)
				{
					case 0:
						for (int j = 0; j < 80; j++)
						{
							switch (j)
							{
								case 0:
									arrChar[j] = '┏';
									break;
								case 79:
									arrChar[j] = '┓';
									break;
								default:
									arrChar[j] = '━';
									break;
							}
						}
						Console.SetCursorPosition(0, i);
						Console.Write(arrChar);
						break;
					case 24:
						for (int j = 0; j < 80; j++)
						{
							switch (j)
							{
								case 0:
									arrChar[j] = '┗';
									break;
								case 79:
									arrChar[j] = '┛';
									break;
								default:
									arrChar[j] = '━';
									break;
							}
						}
						Console.SetCursorPosition(0, i);
						Console.Write(arrChar);
						break;
					default:
						for (int j = 0; j < 80; j++)
						{
							switch (j)
							{
								case 0:
									arrChar[j] = '┃';
									break;
								case 79:
									arrChar[j] = '┃';
									break;
								default:
									arrChar[j] = ' ';
									break;
							}
						}
						Console.SetCursorPosition(0, i);
						Console.Write(arrChar);
						break;
				}
			}
		}

		static void ConsoleWriteXY(int a, int b, string str)
		{
			Console.SetCursorPosition(a, b);
			Console.Write(str);
		}

		static void DungeonExploring()
		{
			EdgeDraw();
			ConsoleWriteXY(35, 12, "던전 탐험중");
			Thread.Sleep(500);
			EdgeDraw();
			ConsoleWriteXY(35, 12, "던전 탐험중.");
			Thread.Sleep(500);
			EdgeDraw();
			ConsoleWriteXY(35, 12, "던전 탐험중..");
			Thread.Sleep(500);
			EdgeDraw();
			ConsoleWriteXY(35, 12, "던전 탐험중...");
			Thread.Sleep(500);
		}

        static void Main(string[] args)
        {
            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);

            //콘솔 버퍼 크기도 설정(스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

			Random rand = new Random();

			const int MAXHP = 100;

			int att = 70;
			int addAtt = 0;
			int monsterAtt = 0;
			int currentHp = 100;
			int damage = 0;
			int gold = 100;
			int reward = 0;
			int choice = 0;
			int eventNum = 0;

			bool isLoop = true;

			EdgeDraw();
			ConsoleWriteXY(35, 12, "RPG TEST");
			Thread.Sleep(3000);

			while(isLoop)
			{
				EdgeDraw();
				ConsoleWriteXY(30, 5, "   캐릭터 상태   ");
				ConsoleWriteXY(30, 6, "=================");
				ConsoleWriteXY(30, 7, "    공격력 : " + att);
				ConsoleWriteXY(30, 8, "    체력   : " + currentHp);
				ConsoleWriteXY(30, 9, "    소지금 : " + gold);
				ConsoleWriteXY(30, 10, "=================");
				ConsoleWriteXY(30, 11, "      메뉴       ");
				ConsoleWriteXY(30, 12, "=================");
				ConsoleWriteXY(30, 13, "    1.던전 탐험  ");
				ConsoleWriteXY(30, 14, "    2.장비 뽑기  ");
				ConsoleWriteXY(30, 15, "    3.캐릭터 훈련  ");
				ConsoleWriteXY(30, 16, "    4.휴식하기  ");
				ConsoleWriteXY(30, 17, "    5.게임 종료하기  ");
				ConsoleWriteXY(25, 19, "원하는 메뉴의 번호를 입력 :");

				choice = int.Parse(Console.ReadLine());
				Thread.Sleep(1000);

				switch(choice)
				{
					case 1:
						DungeonExploring();

						eventNum = rand.Next(1, 101);

						if (eventNum < 31)
						{
							EdgeDraw();
							ConsoleWriteXY(25, 12, "몬스터와 조우하였다");
							monsterAtt = rand.Next(50, 201);

							if (att < monsterAtt)
							{
								damage = monsterAtt / 4;
								currentHp -= damage;
								ConsoleWriteXY(25, 13, "몬스터가 나보다 강했다");
								ConsoleWriteXY(25, 14, $"나는 {damage}에 데미지를 입었다");

								if (currentHp < 1)
								{
									EdgeDraw();
									ConsoleWriteXY(25, 12, "나의 체력이 바닥나 쓰러졌다...");
									isLoop = false;
								}
							}
							else
							{
								reward = rand.Next(100, 251);
								gold += reward;
								ConsoleWriteXY(25, 13, "몬스터를 손쉽게 처치하였다");
								ConsoleWriteXY(25, 14, $"몬스터를 처치하여 {reward}골드를 획득히였다");
							}
						}
						else if (eventNum < 81)
						{
							reward = rand.Next(50, 321);
							gold += reward;
							EdgeDraw();
							ConsoleWriteXY(25, 12, "보물상자를 발견하였다");
							ConsoleWriteXY(25, 13, $"{reward}골드를 획득히였다");
						}
						else
						{
							damage = 10;
							currentHp -= damage;
							ConsoleWriteXY(25, 12, "함정에 빠졌다!");
							ConsoleWriteXY(25, 12, $"{damage}에 체력을 잃었다...!");
							EdgeDraw();
						}
						Thread.Sleep(3000);
						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						break;
					default:
						break;
				}
			}

			ConsoleWriteXY(35, 12, "GAME OVER!!");  
            
        }
    }
}
