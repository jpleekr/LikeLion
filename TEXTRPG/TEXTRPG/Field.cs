using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class Field
    {
        Player m_pPlayer = null;
        Monster m_pMonster = null;

        public void SetPlayer(Player player) { m_pPlayer = player; }

        public void Progress()
        {
            int iInput = 0;

            while(true)
			{
				Console.Clear();

				m_pPlayer.Render();
				DrawMap();

				iInput = int.Parse(Console.ReadLine());

				if (iInput == 4)
					break;

				if(iInput <= 3)
				{
					CreateMonster(iInput);
					Fight();
				}
			}
		}

		public void Create(string _strName, int _iHP, int _iAttack, out Monster pMonster)
		{
			pMonster = new Monster(_strName, _iHP, _iAttack);
		}

		public void CreateMonster(int input)
		{
			switch(input)
			{
				case 1:
					Create("초보몹", 30, 3, out m_pMonster);
					break;
				case 2:
					Create("중수몹", 60, 6, out m_pMonster);
					break;
				case 3:
					Create("고수몹", 90, 9, out m_pMonster);
					break;
			}
		}

		public void Fight()
		{
			int iInput = 0;

			while(true)
			{
				Console.Clear();
				m_pPlayer.Render();
				m_pMonster.Render();

				Console.WriteLine("1.공격 2.도망 : ");
				iInput = int.Parse(Console.ReadLine());

				if(iInput == 1)
				{
					m_pPlayer.SetDamage(m_pMonster.iAttack);
					m_pMonster.SetDamage(m_pPlayer.iAttack);

					if(m_pPlayer.iHP <= 0)
					{
						m_pPlayer.SetHp(100);
						break;
					}
				}

				if(iInput == 2 || m_pMonster.iHP <=0)
				{
					m_pMonster = null;
					break;
				}

			}
		}


		public void DrawMap()
		{
			Console.WriteLine("1. 초보맵");
			Console.WriteLine("2. 중수맵");
			Console.WriteLine("3. 고수맵");
			Console.WriteLine("4. 전단계");
			Console.WriteLine("===========");
			Console.WriteLine("맵을 선택하세요 : ");
		}
	}
}
