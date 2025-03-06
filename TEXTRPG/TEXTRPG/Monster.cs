using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class Monster : Character
	{

        public override void SetDamage(int iAttack) { iHP -= iAttack; }

		public override void Render()
		{
			Console.WriteLine("=================");
			Console.WriteLine("몬스터 이름 : " + strName);
			Console.WriteLine("체력 : " + iHP + "\t공격력 : " + iAttack);

		}

		public Monster() { }

		public Monster(string name, int hp, int att )
		{
			strName = name;
			iHP = hp;
			iAttack = att;
		}

		~Monster() { }
	}
}
