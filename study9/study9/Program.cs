using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {
			/*int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
				case 2:
					Console.WriteLine("환요일");
					break;
				case 3:
					Console.WriteLine("수요일");
					break;
				case 4:
					Console.WriteLine("목요일");
					break;
				case 5:
					Console.WriteLine("금요일");
					break;
				default:
					Console.WriteLine("주말");
					break;
			}*/

			/*int characterNum = 0,att = 0, def = 0;

			Console.WriteLine("원하는 캐릭터의 번호를 입력하세요 : ");
			Console.WriteLine("1.전사 2.마법사 3.도적 ");
			characterNum = int.Parse(Console.ReadLine());

			switch (characterNum)
			{
				case 1:
					Console.WriteLine("전사를 선택하셨습니다");
					att = 100;
					def = 90;
					Console.WriteLine("공격력 : " + att);
					Console.WriteLine("방어력 : " + def);
					break;
				case 2:
					Console.WriteLine("마법사를 선택하셨습니다");
					att = 100;
					def = 90;
					Console.WriteLine("공격력 : " + att);
					Console.WriteLine("방어력 : " + def);
					break;
				case 3:
					Console.WriteLine("도적를 선택하셨습니다");
					att = 100;
					def = 90;
					Console.WriteLine("공격력 : " + att);
					Console.WriteLine("방어력 : " + def);
					break;
				default:
					Console.WriteLine("잘못된 선택입니다");
					break;
			}*/

			/*for(int i = 1; i <= 5; i++)
			{
				Console.WriteLine("숫자 : " + i);
			}*/

			/*for(int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
			}*/

			/*int sum = 0;

			for(int i = 1; i < 11; i++)
			{
				sum += i;
			}

			Console.WriteLine("1~10까지의 합은 : " + sum);*/

			/*int count = 1;

			while(count < 6)
			{
				Console.WriteLine("Count : " + count);
				count++;
			}*/

			/*Random rand = new Random();
			int randomInRange= 0;

			for (int i = 0; i < 10; i++)
			{
				randomInRange = rand.Next(5, 15);
				Console.WriteLine("5이상 14미만의 램덤 정수 : " + randomInRange);
			}*/

			/*Random rand = new Random();
			int randInt = 0;

			for(int i = 0; i < 20; i++)
			{
				randInt = rand.Next(1, 101);

				if (randInt < 11)
				{
					Console.WriteLine("도끼등급 SSS등급");
				}
				else if (randInt < 51)
				{
					Console.WriteLine("도끼등급 SS등급");
				}
				else
				{
					Console.WriteLine("도끼등급 S등급");
				}

				Thread.Sleep(500);
			}*/

			/*int x = 5;

			do
			{
				Console.WriteLine("최소 한번은 실행됩니다.");
				x--;
			}while (x > 0);*/

			/*for(int i = 0; i < 11; i++)
			{
				if(i == 5)
				{
					break;
				}

				Console.WriteLine(i);
			}*/

			/*for(int i = 1; i < 11; i++)
			{
				if (i % 2 == 0) continue;
				Console.WriteLine(i);
			}*/

			/*int n = 1;

			strat:

			if(n <= 5)
			{
				Console.WriteLine(n);
				n++;

				goto strat;
			}*/
        }
    }
}
