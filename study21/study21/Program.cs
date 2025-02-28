using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study21
{
    /*class Person
    {
        private string name;

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }
    }*/

    /*class Person
    {
        private string name;

        public string Name
        {
            get { return name; }  set { name = value; }
        }
    }*/

    /*class Person
    {
        private int count = 100;

        public string Name { get; set; }
        public int Count
        {
            get { return count; }
        }
        public float Balance { get; private set; }

        public void AddBal()
        {
            Balance += 100;
        }
    }*/

    class Marin
    {
        public string Name { get; set; } = "마린";
        public int Mineral { get; set; } = 50;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Marin m = new Marin();

            Console.WriteLine($"이름 {m.Name} 미네랄 {m.Mineral}");

			/*Person p = new Person();

            p.Name = "홍길동";
            p.AddBal();
            Console.WriteLine($"이름 :   {p.Name} Cuont : {p.Count} Blance : {p.Balance}");*/  
        }
    }
}
