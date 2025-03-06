using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study36
{
    class Person
    {
        private string Name ="홍길동";

        public void SetName(string n)
        {
            Name = n;
        }
        public string GetName()
        {
            return Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Console.WriteLine(p.GetName());
            p.SetName("Bob");
            Console.WriteLine(p.GetName());

        }
    }
}
