using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTest
{
	class Player : Character
	{
		public void SetHp(int a)
		{
			nHp = a;
		}

		public void Init(int a)
		{
			switch (a)
			{
				case 1:
					strName = "기사";
					nHp = 100;
					nAttack = 10;
					break;
				case 2:
					strName = "마법사";
					nHp = 90;
					nAttack = 15;
					break;
				case 3:
					strName = "도둑";
					nHp = 85;
					nAttack = 13;
					break;
			}
		}

		public override void Render()
		{
			Console.WriteLine("==============");
			Console.WriteLine($"직업 이름 : {strName}");
			Console.WriteLine($"체력 : {nHp}\t공격력 : {nAttack}");
		}

		public override void SetDamage(int Attack)
		{
			nHp -= Attack;
		}
	}
}
