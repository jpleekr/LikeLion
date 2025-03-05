using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study30
{
    class Animal
    {
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
			/*Dog myDog = new Dog();
            Animal myAnimal = myDog;

            myDog.Name = "aa";
            myAnimal.Name = "bb";

            Console.WriteLine(myDog.Name);

            myAnimal.Speak();*/

			Animal myAnimal = new Dog(); //업캐스팅
										 //Dog myDog = (Dog)myAnimal; //다운캐스팅 (명시적 변환)

			Dog myDog = myAnimal as Dog;

			if (myDog != null)
			{
				myDog.Bark();
			}
			else
			{
				Console.WriteLine("변환 실패!");
			}

			//Animal myAnimal2 = new Animal();
			//Dog myDog = (Dog)myAnimal2;

			if (myAnimal is Dog myDog1)
			{
				myDog1.Bark(); //실행
			}
			else
			{
				Console.WriteLine("변환할수 없습니다.");
			}

		}
    }
}
