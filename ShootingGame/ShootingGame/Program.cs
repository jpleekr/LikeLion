using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{

    public class Missaile
    {
        public int x;
        public int y;
        public bool isFire;
    }

    public class Player
    {
		const int UPKEY = 72;
		const int DOWNKEY = 80;
		const int LEFTKEY = 75;
		const int RIGHTKEY = 77;
        const int SPACEBAR = 32;

		[DllImport("msvcrt.dll")]
		static extern int _getch();

        public int playerX;
        public int playerY;
        public Missaile[] playerMissail = new Missaile[20];
        public Missaile[] playerMissail2 = new Missaile[20];
        public Missaile[] playerMissail3 = new Missaile[20];
        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;
        
        public Player()
        {
            playerX = 0;
            playerY = 12;

            for(int i = 0; i < playerMissail.Length; i++)
            {
                playerMissail[i] = new Missaile();
                playerMissail[i].x = 0;
                playerMissail[i].y = 0;
                playerMissail[i].isFire = false;

				playerMissail2[i] = new Missaile();
				playerMissail2[i].x = 0;
				playerMissail2[i].y = 0;
				playerMissail2[i].isFire = false;

				playerMissail3[i] = new Missaile();
				playerMissail3[i].x = 0;
				playerMissail3[i].y = 0;
				playerMissail3[i].isFire = false;

			}
        }

        public void GmaeMain()
		{
            KeyControl();
            PlayerDraw();
		}

		public void KeyControl()
		{
            int pressKey;

            if(Console.KeyAvailable)
            {
                pressKey = _getch();

                switch(pressKey)
                {
                    case UPKEY:
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
					case LEFTKEY:
						playerX--;
						if (playerX < 0)
							playerX = 0;
						break;
					case RIGHTKEY:
						playerX++;
						if (playerX > 75)
							playerX = 75;
						break;
					case DOWNKEY:
						playerY++;
						if (playerY > 21)
							playerY = 21;
						break;
					case SPACEBAR:
						for (int i = 0; i < playerMissail.Length; i++)
						{
							if (playerMissail[i].isFire == false)
							{
								playerMissail[i].isFire = true;
								playerMissail[i].x = playerX + 5;
                                playerMissail[i].y = playerY + 1;
								break;
							}
						}
						break;


				}
			}


		}

        public void MissaileDraw()
        {
            string missaile = "- >";

            for(int i = 0; i < playerMissail.Length; i++)
            {
                if (playerMissail[i].isFire == true)
                {
                    Console.SetCursorPosition(playerMissail[i].x, playerMissail[i].y);
                    Console.Write(missaile);

                    playerMissail[i].x++;

                    if (playerMissail[i].x > 78)
                    {
                        playerMissail[i].isFire = false;
                    }

                }
            }
        }

        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };

            for(int i =0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
			}

        }

        public void ClashEnemyAnndMissaile(Enemy enemy)
        {
            for(int i = 0; i < playerMissail.Length; i++)
            {
                if (playerMissail[i].isFire == true)
                {
                    if (playerMissail[i].y == enemy.enemyY)
                    {
                        if (playerMissail[i].x >= (enemy.enemyX - 1) 
                            && playerMissail[i].x <= (enemy.enemyX + 1))
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerMissail[i].isFire = false;
                        }
                    }
                }
            }
        }

        public void UIScore()
        {
			Console.SetCursorPosition(63, 0);
			Console.Write("┏━━━━━━━━━━━━━━┓");
			Console.SetCursorPosition(63, 1);
			Console.Write("┃              ┃");
			Console.SetCursorPosition(65, 1);
			Console.Write("Score : " + Score);
			Console.SetCursorPosition(63, 2);
			Console.Write("┗━━━━━━━━━━━━━━┛");
		}

        public void CrashItem()
        {

        }


	}

    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            string enemy = "<-0->";

            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy);
        }

        public void EnmeyMove()
        {
            Random rand = new Random();
            enemyX--;

            if(enemyX < 2)
            {
                enemyX = 77;
                enemyY = rand.Next(2, 22);
            }
        }
    }

    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item";
            Console.Write(ItemSprite);

		}

        public void ItemMove()
        {
            /*if(itemX <= 1 || itemY <= 1)
            {
                ItemLife = false;
            }*/
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Player player = new Player();
            Enemy enemy = new Enemy();

            int dwTime = Environment.TickCount;

            while(true)
            {
				if(dwTime + 100 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;

                    Console.Clear();
                    player.GmaeMain();

					player.MissaileDraw();

                    enemy.EnmeyMove();
                    enemy.EnemyDraw();

                    player.ClashEnemyAnndMissaile(enemy);
                }
            }

        }
    }
}
