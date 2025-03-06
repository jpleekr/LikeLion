﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study39
{
    abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("동물이 잠을 잡니다");
        }
    }

	class Dog : Animal
	{
		public override void MakeSound()
		{
            Console.WriteLine("멍멍!");
		}
	}

	class Cat : Animal
	{
		public override void MakeSound()
		{
			Console.WriteLine("야옹!");
		}
	}


	class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.MakeSound();
            myDog.Sleep();

			myCat.MakeSound();
			myCat.Sleep();

		}
    }
}
