using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTest
{
    class Field
    {
        Monster m_pMonster = null;

        public void Procease(Player player)
        {
            bool isBack = false;

            while(!isBack)
            {
                Console.Clear();
                player.Render();
                SelectMap();

                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        CreateMonster(1);
                        Fight(player);
                        break;
				    case 2:
					    CreateMonster(2);
					    Fight(player);
					    break;
				    case 3:
                        CreateMonster(3);
                        Fight(player);
					    break;
				    case 4:
                        isBack = true;
					    break;
                    default:
                        break;
			    }
            }

        }

        public void SelectMap()
        {
			Console.WriteLine("1. 초보맵");
			Console.WriteLine("2. 중수맵");
			Console.WriteLine("3. 고수맵");
			Console.WriteLine("4. 전단계");
			Console.WriteLine("==============");
			Console.WriteLine("맵을 선택하세요 : ");
		}

        public void CreateMonster(int a)
        {
            m_pMonster = new Monster(a);
        }

        public void Fight(Player player)
        {
            int Input = 0;

            while(true)
            {
                Console.Clear();
                player.Render();
				m_pMonster.Render();

				Console.WriteLine("1.공격 2.도망 : ");
				Input = int.Parse(Console.ReadLine());

				if (Input == 1)
				{
					player.SetDamage(m_pMonster.nAttack);
					m_pMonster.SetDamage(player.nAttack);

				    if (player.nHp <= 0)
                    {
                        player.SetHp(100);
                        break;
                    }
				}

                if( Input == 2 && m_pMonster.nHp <= 0)
                {
                    m_pMonster = null;
                    break;
                }
			}

        }

    }
}
