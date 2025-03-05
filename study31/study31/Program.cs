using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study31
{
    class Animal
    {
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다");
        }
    }

    class Dog : Animal
    {
		public override void Speak()
		{
            Console.WriteLine("멍멍!");
		}

        public void WagTail()
        {
            Console.WriteLine("꼬리를 흔든다");
        }
	}

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog();

            myAnimal.Name = "aa";

            myAnimal.Speak();

            Dog d = myAnimal as Dog;
			d.Name = "bb";

            Console.WriteLine(myAnimal.Name);
            d.WagTail();

            Animal myAni = new Animal();

            myAni.Speak();

        }
    }
}
