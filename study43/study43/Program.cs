using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study43
{
    interface IAinimal
    {
        void MakeSound();
    }

	class Dog : IAinimal
	{
		public void MakeSound()
		{
            Console.WriteLine("멍멍!");
		}
	}

	class Cat : IAinimal
	{
		public void MakeSound()
		{
			Console.WriteLine("야옹!");
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			IAinimal dog = new Dog();
			IAinimal cat = new Cat();

			dog.MakeSound();
			cat.MakeSound();

        }
    }
}
