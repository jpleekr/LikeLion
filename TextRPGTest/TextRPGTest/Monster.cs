using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTest
{
	class Monster : Character
	{
		public Monster(int a)
		{
			switch(a)
			{
				case 1:
					strName = "초보몹";
					nHp = 30;
					nAttack = 3;
					break;
				case 2:
					strName = "중수몹";
					nHp = 60;
					nAttack = 6;
					break;
				case 3:
					strName = "고수몹";
					nHp = 90;
					nAttack = 9;
					break;
			}
		}

		public override void Render()
		{
			Console.WriteLine("==============");
			Console.WriteLine($"몬스터 이름 : {strName}");
			Console.WriteLine($"체력 : {nHp}\t공격력 : {nAttack}");
		}

		public override void SetDamage(int Attack)
		{
			nHp -= Attack;
		}
	}
}
