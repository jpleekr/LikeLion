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
		public const int UPKEY = 72;
		public const int DOWNKEY = 80;
		public const int LEFTKEY = 75;
		public const int RIGHTKEY = 77;
		public const int SPACEBAR = 32;

		public const int WIDYH = 80;
		public const int HIGHT = 25;


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

			UIScore();

			if (item.ItemLife)
			{
				item.ItemMove();
				item.ItemDraw();
				CrashItem();
			}
		}

		public void KeyControl()
		{
            int pressKey;

            if(Console.KeyAvailable)
            {
				pressKey = _getch();

				if (pressKey == 0 || pressKey == 224)
				{
					pressKey = _getch();
				}

				switch (pressKey)
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
						if (playerX > (WIDYH - 5))
							playerX = (WIDYH - 5);
						break;
					case DOWNKEY:
						playerY++;
						if (playerY > (HIGHT - 4))
							playerY = (HIGHT - 4);
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

						for (int i = 0; i < playerMissail2.Length; i++)
						{
							if (playerMissail2[i].isFire == false)
							{
								playerMissail2[i].isFire = true;
								playerMissail2[i].x = playerX + 5;
								playerMissail2[i].y = playerY;
								break;
							}
						}

						for (int i = 0; i < playerMissail3.Length; i++)
						{
							if (playerMissail3[i].isFire == false)
							{
								playerMissail3[i].isFire = true;
								playerMissail3[i].x = playerX + 5;
								playerMissail3[i].y = playerY + 2;
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

                    if (playerMissail[i].x > (WIDYH - 3))
                    {
                        playerMissail[i].isFire = false;
                    }

                }
            }
        }

		public void MissaileDraw2()
		{
			string missaile = "- >";

			for (int i = 0; i < playerMissail2.Length; i++)
			{
				if (playerMissail2[i].isFire == true)
				{
					Console.SetCursorPosition(playerMissail2[i].x, playerMissail2[i].y);
					Console.Write(missaile);

					playerMissail2[i].x++;

					if (playerMissail2[i].x > (WIDYH - 3))
					{
						playerMissail2[i].isFire = false;
					}

				}
			}
		}

		public void MissaileDraw3()
		{
			string missaile = "- >";

			for (int i = 0; i < playerMissail3.Length; i++)
			{
				if (playerMissail3[i].isFire == true)
				{
					Console.SetCursorPosition(playerMissail3[i].x, playerMissail3[i].y);
					Console.Write(missaile);

					playerMissail3[i].x++;

					if (playerMissail3[i].x > (WIDYH - 3))
					{
						playerMissail3[i].isFire = false;
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
							item.ItemLife = true;
							item.itemX = enemy.enemyX;
							item.itemY = enemy.enemyY;

							Random rand = new Random();
                            enemy.enemyX = (WIDYH - 5);
                            enemy.enemyY = rand.Next(2, (HIGHT - 3));

                            playerMissail[i].isFire = false;

							Score += 100;
						}
                    }
                }
            }

			for (int i = 0; i < playerMissail2.Length; i++)
			{
				if (playerMissail2[i].isFire == true)
				{
					if (playerMissail2[i].y == enemy.enemyY)
					{
						if (playerMissail2[i].x >= (enemy.enemyX - 1)
							&& playerMissail2[i].x <= (enemy.enemyX + 1))
						{
							item.ItemLife = true;
							item.itemX = enemy.enemyX;
							item.itemY = enemy.enemyY;

							Random rand = new Random();
							enemy.enemyX = (WIDYH - 5);
							enemy.enemyY = rand.Next(2, (HIGHT - 3));

							playerMissail2[i].isFire = false;

							Score += 100;
						}
					}
				}
			}

			for (int i = 0; i < playerMissail3.Length; i++)
			{
				if (playerMissail3[i].isFire == true)
				{
					if (playerMissail3[i].y == enemy.enemyY)
					{
						if (playerMissail3[i].x >= (enemy.enemyX - 1)
							&& playerMissail3[i].x <= (enemy.enemyX + 1))
						{
							item.ItemLife = true;
							item.itemX = enemy.enemyX;
							item.itemY = enemy.enemyY;

							Random rand = new Random();
							enemy.enemyX = (WIDYH - 5);
							enemy.enemyY = rand.Next(2, (HIGHT - 3));

							playerMissail3[i].isFire = false;

							Score += 100;
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
			if (playerY + 1 == item.itemY)
			{
				if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
				{
					item.ItemLife = false;

					if (itemCount < 3)
						itemCount++;

					for (int i = 0; i < 20; i++) //총알 초기화
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
			}
		}


	}

    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 75;
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
                enemyX = 75;
                enemyY = rand.Next(2, (Player.HIGHT - 3));
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
            ItemSprite = "Item★";
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

			Console.SetWindowSize(Player.WIDYH, Player.HIGHT);
			Console.SetBufferSize(Player.WIDYH, Player.HIGHT);

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

					if (player.itemCount == 0)
					{
						player.MissaileDraw();
					}
					else if (player.itemCount == 1)
					{
						player.MissaileDraw();
						player.MissaileDraw2();
					}
					else
					{
						player.MissaileDraw();
						player.MissaileDraw2();
						player.MissaileDraw3();
					}

					enemy.EnmeyMove();
                    enemy.EnemyDraw();

                    player.ClashEnemyAnndMissaile(enemy);
                }
            }

        }
    }
}
