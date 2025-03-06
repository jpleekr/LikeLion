using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class Player : Character
	{
        public override void SetDamage(int iAttack) { iHP -= iAttack; }

        public void SetHp(int hp) { iHP = hp; }

        public void SelectJob()
        {
            Console.WriteLine("직업을 선택하세요 (1.기사 2.마법사 3.도둑) : ");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch(iInput)
            {
                case 1:
                    strName = "기사";
                    iHP = 100;
                    iAttack = 10;
                    break;
				case 2:
					strName = "마법사";
					iHP = 90;
					iAttack = 15;
					break;
				case 3:
					strName = "도둑";
					iHP = 85;
					iAttack = 13;
					break;
			}
        }

        public override void Render()
        {
            Console.WriteLine("=================");
            Console.WriteLine("직업 이름 : " + strName);
            Console.WriteLine("체력 : " + iHP + "\t공격력 : " +  iAttack);

        }

        public Player() { }

        ~Player() { }

    }
}
