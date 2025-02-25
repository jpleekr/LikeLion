using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 모험가키우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int gold = 500;
            int health = 100;
            int power = 10;
            int input = 0;
            int eventChance = 0;
            int damage = 0;
            int reward = 0;
            int rnd = 0;
            int heal = 0;

			bool isAlive = true;

			Console.OutputEncoding = Encoding.UTF8;

			Console.WriteLine("   ⚔️      모험가 키우기    ⚔️     ");
            Thread.Sleep(3000);

            while(isAlive)
            {
                Console.Clear();
                Console.WriteLine("   현재 상태   ");
                Console.WriteLine("===============");
                Console.WriteLine($"   체력 : {health}   ");
                Console.WriteLine($"   골드 : {gold}   ");
                Console.WriteLine($"   공격력 : {power}   ");
				Console.WriteLine("\n===============");
				Console.WriteLine("      메뉴     ");
				Console.WriteLine("===============");
				Console.WriteLine("   1.탐험하기 🏕️  ");
                Console.WriteLine("   2.장비 뽑기 🎲 (1000골드) ");
                Console.WriteLine("   3.휴식하기 💤 (체력 + 20) ");
                Console.WriteLine("   4.게임종료   ");
                Console.Write("   입력 :   ");

                input = int.Parse(Console.ReadLine());

                Thread.Sleep(1000);

                switch(input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("탐험을 떠납니다.");
                        Thread.Sleep(500);
						Console.Clear();
						Console.WriteLine("탐험을 떠납니다..");
						Thread.Sleep(500);
						Console.Clear();
						Console.WriteLine("탐험을 떠납니다...");
						Thread.Sleep(500);
						Console.Clear();
						Console.WriteLine("탐험을 떠납니다...");
						Thread.Sleep(500);

                        eventChance = rand.Next(1, 101);

                        if(eventChance <= 30)
                        {
                            damage = rand.Next(5, 21);
						    Console.WriteLine($" ⚔️ 몬스터를 만났습니다!  (체력 - {damage})");
                            health -= damage;
                        }
						else if(eventChance <= 70)
						{
                            reward = rand.Next(100, 301);
						    Console.WriteLine($" 💰 보물을 발견했습니다!  (+ {reward}골드)");
                            gold += reward;
						}
						else
						{
                            heal = rand.Next(10, 31);
						    Console.WriteLine($" 🌿 신비한 약초를 발견했습니다!  (+ {heal}체력)");
                            health += heal;
						}

                        if(health <=0)
                        {
                            Console.WriteLine("\n 💀 체력이 0이 되어 시망했습니다... 게임 오버!");
                            isAlive = false;
                        }
                        Thread.Sleep(3000);
						break;
					case 2:
                        if(gold >= 1000)
                        {
                            gold -= 1000;
                            Console.Clear();
                            Console.WriteLine("  🎲 장비를 뽑습니다! 🎲  ");
                            Thread.Sleep(1000);

                            rnd = rand.Next(1, 101);

                            if(rnd == 1)
                            {
                                Console.WriteLine("SSS급 전설의 검 (공격력 + 50) 획득!");
                                power += 50;
                            }
							else if(rnd <= 10)
							{
								Console.WriteLine("SS급 희귀한 검 (공격력 + 30) 획득!");
								power += 30;
							}
							else if (rnd <= 30)
							{
								Console.WriteLine("S급 강철 검 (공격력 + 20) 획득!");
								power += 20;
							}
							else
							{
								Console.WriteLine("녹슨검 (공격력 + 5) 획득!");
								power += 5;
							}
                            Thread.Sleep(1000);
						}
                        else
                        {
							Console.WriteLine("골드가 필요합니다! (1000 골드 필요)");
                            Thread.Sleep(1000);
                        }
						break;
					case 3:
						Console.WriteLine("휴식을 취합니다... (+20 체력)");
                        health += 20;
                        Thread.Sleep(1000);
						break;
					case 4:
                        isAlive = false;
						break;
                    default:
						Console.WriteLine("잘못된 입력입니다. 다시 선택하세요");
                        Thread.Sleep(1000);
                        break;
				}
            }

            Console.Clear();
            Console.WriteLine("게임을 종료합니다!");
        }
    }
}
