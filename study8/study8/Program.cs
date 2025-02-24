using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("D학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }*/

            /*int nMoney = 0, playerAttackPower = 100;
            string playerName = null, playerWeaponName = null;

            Console.Write("캐릭터 이름을 입력해주세요 : ");
            playerName = Console.ReadLine();

            Console.Write("소지금을 입력해주세요 : ");
            nMoney = int.Parse(Console.ReadLine());

            if (nMoney < 100)
            {
                Console.WriteLine("\n무한의 대검을 획득하셨습니다");
				playerWeaponName = "무한의 대검";
				playerAttackPower += 1;
            }
            else if (nMoney < 200)
            {
                Console.WriteLine("\n카타나을 획득하셨습니다");
				playerWeaponName = "카타나";
                playerAttackPower += 2;
            }
            else if (nMoney < 300)
            {
                Console.WriteLine("\n진은검을 획득하셨습니다");
				playerWeaponName = "진은검";
                playerAttackPower += 3;
            }
            else if (nMoney < 400)
            {
                Console.WriteLine("\n집행검을 획득하셨습니다");
				playerWeaponName = "집행검";
                playerAttackPower += 4;
            }
            else if (nMoney < 500)
            {
                Console.WriteLine("\n엑스칼리버을 획득하셨습니다");
				playerWeaponName = "엑스칼리버";
                playerAttackPower += 5;
            }
            else if (nMoney < 600)
            {
                Console.WriteLine("\n유령검을 획득하셨습니다");
				playerWeaponName = "유령검";
                playerAttackPower += 6;
            }
            else
            {
				Console.WriteLine("\n전설의 검을 획득하셨습니다");
				playerWeaponName = "전설의 검";
				playerAttackPower += 7;
			}

            Console.WriteLine("\n캐릭터 스테이터스");
            Console.WriteLine("=================");
            Console.WriteLine("캐릭터 이름   : " + playerName);
            Console.WriteLine("무기 이름     : " + playerWeaponName);
            Console.WriteLine("캐릭터 공격력 : " + playerAttackPower);*/

            /*int a = 0, b = 0, c = 0, max = 0;
            
            Console.WriteLine("정수 3개를 입력하세요 : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                max = (a > c) ? a : c;
            }
            else
            {
                max = (b > c) ? b : c;               
            }

            Console.WriteLine("최댓값음 : " + max);*/

            /*int score = 0;
            bool reTry = true;

            Console.WriteLine("점수를 입력해주세요");
            score = int.Parse(Console.ReadLine());

            while(reTry)
            {
                if (score > 100)
                {
                    Console.WriteLine("\n점수를 잘못입력하셨슴니다 다시 입력하세요 : ");
                    score = int.Parse(Console.ReadLine());
                }
                else if (score < 0)
                {
                    Console.WriteLine("\n점수를 잘못입력하셨슴니다 다시 입력하세요 : ");
                    score = int.Parse(Console.ReadLine());
                }
                else
                {
                    reTry = false;
                }
            }

			if (score >= 90)
			{
				Console.WriteLine("\nA학점");
			}
			else if (score >= 80)
			{
				Console.WriteLine("\nB학점");
			}
			else if (score >= 70)
			{
				Console.WriteLine("\nC학점");
			}
			else if (score >= 80)
			{
				Console.WriteLine("\nD학점");
			}
			else
			{
				Console.WriteLine("\nF학점");
			}*/

            /*int a = 0, b = 0, result = 0;
            char ch;
            bool reTry = true;

            Console.WriteLine("숫자 두개를 입력해주세요 : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("원하는 연산자를 입력해주세요 : ");
            ch = char.Parse(Console.ReadLine());

            while (reTry)
            {
                if (ch == '+')
                {
                    result = a + b;
                    Console.WriteLine(result);
                    reTry = false;
                }
                else if (ch == '-')
                {
                    result = a - b;
                    Console.WriteLine(result);
                    reTry = false;
                }
                else if (ch == '*')
                {
                    result = a * b;
                    Console.WriteLine(result);
                    reTry = false;
                }
                else if (ch == '/')
                {
                    result = a / b;
                    Console.WriteLine(result);
                    reTry = false;
                }
                else
                {
                    Console.WriteLine("연산자를 잘못입력하셨습니다 다시입력헤주세요 : ");
                    ch = char.Parse(Console.ReadLine());
                }
			}*/
		}
    }
}
