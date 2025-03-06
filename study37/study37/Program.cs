using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study37
{
    class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = "Unkown";
            Age = 0;
        }

        public Person(string name)
        {
            Name = name;
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
		class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p1 = new Person("Bob");
            Person p2 = new Person("카타리나", 20);

            Console.WriteLine(p.Name + "," + p.Age);
            Console.WriteLine(p1.Name + "," + p1.Age);
            Console.WriteLine(p2.Name + "," + p2.Age);

        }
    }
}
