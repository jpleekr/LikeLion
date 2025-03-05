using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0305HW
{
    class Champion
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Champion()
        {
            Name = "non";
            Power = 0;
        }

        public virtual void Attack(Champion target)
        {
            Console.WriteLine($"{Name}이(가) {target.Name}을 공격하였습니다 ({Power}에 대미지를 입혔습니다)");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이(가) 이동합니다");
        }
        
    }

    class Olaf : Champion
    {
        public Olaf()
        {
            Name = "Olaf";
            Power = 100;
		}

		public override void Attack(Champion target)
		{
			Console.WriteLine($"{Name}이(가) {target.Name}을 도끼를 던져 공격하였습니다 ({Power}에 대미지를 입혔습니다)");
		}

		public override void Move()
		{
			Console.WriteLine($"{Name}이(가) 방해효과를 무시하고 달려갑니다");
		}
	}

    class Ash : Champion
    {
        public Ash()
        {
            Name = "Ash";
            Power = 150;
        }

		public override void Attack(Champion target)
		{
			Console.WriteLine($"{Name}이(가) {target.Name}을 집중사격 공격하였습니다 ({Power}에 대미지를 입혔습니다)");
		}
	}

	class Garen : Champion
    {
        public Garen()
        {
            Name = "Garen";
            Power = 100;
        }
    }

	class DrMundo : Champion
    {
        public DrMundo()
        {
            Name = "Dr.Mundo";
            Power = 50;
        }

		public override void Move()
		{
			Console.WriteLine($"{Name}이(가) 체력을 회복하며 달려갑니다");
		}
	}


	class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            int rand = 0;

            List<Champion> list = new List<Champion>();

            list.Add(new Olaf());
            list.Add(new Ash());
            list.Add(new Garen());
            list.Add(new DrMundo());

            foreach(var champion in list)
            {
                rand = random.Next(0, list.Count);
                champion.Attack(list[rand]);
                champion.Move();
                Console.WriteLine();
            }

        }
    }
}
