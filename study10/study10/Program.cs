using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int choiceNum = 0, money = 100, temp = 0;
            bool isLoop = true;

            Console.WriteLine("       대장장이 키우기       ");
            Thread.Sleep(3000);


            while (isLoop)
            {
                Console.Clear();
                Console.WriteLine("            메뉴            ");
                Console.WriteLine("============================");
                Console.WriteLine("          1.나무캐기        ");
                Console.WriteLine("          2.장비뽑기        ");
                Console.WriteLine("          3.나가기          ");
                choiceNum = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (choiceNum)
                {
                    case 1:
                        Console.WriteLine("       나무를 캡니다       \n");
                        money += 100;
                        Console.WriteLine($"     100골드를 얻었습니다     ");
                        Console.WriteLine($"     소지금 : {money}            ");
                        Thread.Sleep(500);
                        break;
                    case 2:
                        if (money >= 1000)
                        {
                            money -= 1000;

                            for (int i = 0; i < 20; i++)
                            {
                                temp = rand.Next(1, 101);

                                if (temp == 1) Console.WriteLine("도끼등급 SSS");
                                else if (temp >= 2 && temp <= 6) Console.WriteLine("도끼등급 SS");
                                else if (temp >= 7 && temp <= 17) Console.WriteLine("도끼등급 S");
                                else if (temp >= 18 && temp <= 38) Console.WriteLine("도끼등급 A");
                                else if (temp >= 39 && temp <= 69) Console.WriteLine("도끼등급 B");
                                else Console.WriteLine("도끼등급 C");

                                Thread.Sleep(500);
                            }
                        }
                        else
                        {
                            Console.WriteLine("       돈이 부족합니다       ");
                            Thread.Sleep(1000);
                        }
                        break;
                    case 3:
                        Console.WriteLine("       게임을 종료합니다       ");
                        Thread.Sleep(3000);
                        isLoop = false;
                        break;
                    default:
                        Console.WriteLine("       잘못된 메뉴입니다       ");
                        Thread.Sleep(3000);
                        break;
                }
            }

        }
    }
}
