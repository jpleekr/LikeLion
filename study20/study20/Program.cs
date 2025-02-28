using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study20
{
    class Marin
	{
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "마린";
            Mineral = 50;
        }

		public Marin(string _nema, int _mineral)
		{
			Name = _nema;
			Mineral = _mineral;
		}

		public void ShowInfo()
		{
			Console.WriteLine("이름 : " + Name);
			Console.WriteLine("미네랄 : " + Mineral);
		}
	}

	class SCV
	{
		public string Name;
		public int Mineral;

		public SCV()
		{
			Name = "SCV";
			Mineral = 50;
		}

		public SCV(string _nema, int _mineral)
		{
			Name = _nema;
			Mineral = _mineral;
		}

		public void ShowInfo()
		{
			Console.WriteLine("이름 : " + Name);
			Console.WriteLine("미네랄 : " + Mineral);
		}
	}

	class Barracks
	{
		public string Name;
		public int Mineral;

		public Barracks()
		{
			Name = "배럭";
			Mineral = 150;
		}

		public Barracks(string Nema, int Mineral)
		{
			this.Name = Nema;
			this.Mineral = Mineral;
		}

		public void ShowInfo()
		{
			Console.WriteLine("이름 : " + Name);
			Console.WriteLine("미네랄 : " + Mineral);
		}
	}

	class Mineral
	{
		public int MineralAmount;

		public Mineral()
		{
			MineralAmount = 1500;
		}

		public void ShowInfo()
		{
			Console.WriteLine("현재 미네랄 갯수 : " + MineralAmount);
		}
	}

	class Game
	{
		public static int mineral;
		public static int gas;
		public static int charCount;

		public static void ShowInfo()
		{
			Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {charCount}");
		}
	}

	/*class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = "이름 없음";
            Age = 0;
            Console.WriteLine("기본 생성자가 실행됨");
        }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
			Console.WriteLine("매개변수있는 생성자가 실행됨");
		}

		public void ShowInfo()
        {
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("나이 : " + Age);
        }
    }*/

	class Program
    {
        static void Main(string[] args)
        {
			Game.mineral = 50;
			Game.gas = 0;
			Game.charCount = 4;
			Game.ShowInfo();

			Marin marin = new Marin("불꽃테란", 100);
			SCV scv = new SCV("열받은 SCV", 70);
			Barracks barracks = new Barracks();
			Mineral[] mineral = new Mineral[7];

			for(int i = 0; i < mineral.Length; i++)
			{
				mineral[i] = new Mineral();
				mineral[i].ShowInfo();
			}

			marin.ShowInfo();
			scv.ShowInfo();
			barracks.ShowInfo();

            /*Person p1 = new Person("철수", 25);
            Person p2 = new Person("영희", 30);

            p1.ShowInfo();
            p2.ShowInfo();*/
        }
    }
}
