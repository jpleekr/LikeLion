using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTest
{
    class GameManger
    {
        Player m_pPlayer = null;
        Field m_pField = null;

        public void Init()
        {
            m_pPlayer = new Player();
			Console.WriteLine("직업을 선택해 주세요 1.기사 2.마법사 3.도둑");
			m_pPlayer.Init(int.Parse(Console.ReadLine()));
            m_pField = new Field();
        }

        public void Procease()
        {
            while(true)
            {
				Console.Clear();
				m_pPlayer.Render();
                Console.WriteLine("1.사냥터 2.종료 : ");
            
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        m_pField.Procease(m_pPlayer);
                        break;
                    case 2:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
