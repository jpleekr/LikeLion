using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study41
{
    class Parent
    {
        protected string name;

        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine($"부모 생성자 : {name}");
        }
    }

    class Child : Parent
    {
        private int age;

        public Child(string name, int age) : base(name)
        {
            this.age = age;
            Console.WriteLine($"자식 셍성자 : 나이 = {age}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 나이 : {age}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child("홍길동", 25);

            child.ShowInfo();

        }
    }
}
