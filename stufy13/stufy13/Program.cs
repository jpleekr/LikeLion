using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stufy13
{
    class Program
    {
		static int num2 = 20;

		static void PrintHello()
		{
			Console.WriteLine("안녕하세요");

		}

		static void PrintMessage(string message)
		{
			Console.WriteLine(message);
		}

		static int GetNumber()
		{
			return 42;
		}

		static int Add(int a, int b)
		{
			return a + b;
		}

		static void Main(string[] args)
		{
			//PrintHello();
			//PrintMessage("반갑습니다.");

			//int num = GetNumber();
			//Console.WriteLine(num);
			//Console.WriteLine(num2);

			//Console.WriteLine(Add(3, 5));

			//Greet();
			//Greet("철수");

			//Console.WriteLine(Multiply(3, 4));
			//Console.WriteLine(Multiply(2.5, 3.5));

			//int q, r;
			//Divide(10, 3, out q, out r);
			//Console.WriteLine($"몫 :  {q}, 나머지 : {r}");

			//int value = 5;

			//Increase(ref value);

			//Console.WriteLine(value);

		}

		static void Increase(ref int num)
		{
			num += 10;
		}

		static void Divide(int a, int b, out int quotient, out int remainder)
		{
			quotient = a / b;

			remainder = a % b;
		}

		static int Multiply(int a, int b)
		{
			return a * b;
		}

		static double Multiply(double a, double b)
		{
			return a * b;
		}

		static void Greet(string name = "손님")
		{
			Console.WriteLine($"안녕하세요, {name}");
		}
    }
}
