using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
   /* public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

    public class Warrior : Player
    {
        public int Strength { get; set; }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            /* //문제1
             Warrior player = new Warrior();

             player.Name = "Alice";
             player.Score = 70;
             player.Strength = 350;

             Console.WriteLine("이름 : " + player.Name);
             Console.WriteLine("점수 : " + player.Score);
             Console.WriteLine("힘   : " + player.Strength);*/

            /* //문제2

             int num = 0;


             Console.Write("숫자를 입력하세요! : ");

             try
             {
                 num = int.Parse(Console.ReadLine());
                 Console.WriteLine("정수값 : " + num);
             }
             catch (FormatException ex)
             {
                 Console.WriteLine("올바른 숫자를 입력하세요");
             }*/

            /*//문제3

            List<string> list = new List<string>() { "사과", "바나나", "포도" };
            Queue<string> queue = new Queue<string>();
            Stack<int> stack = new Stack<int>();

            queue.Enqueue("첫 번째 작업");
            queue.Enqueue("두 번째 작업");
            queue.Enqueue("세 번째 작업");

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            foreach(string fruit in list)
            {
                Console.WriteLine(fruit);
            }

            foreach(string str in queue)
            {
                Console.WriteLine(str);
            }

			foreach (int i in stack)
			{
				Console.WriteLine(i);
			}*/

            /*//문제4

            string text = null;

            Console.WriteLine("Hello, C# World!를 입력해주세요");
            text = Console.ReadLine();

            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Replace("C#", "CSharp"));
            Console.WriteLine(text.Length);*/

            //문제5

            /*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            var sumNumbers = numbers.Sum();

            foreach(int num in evenNumbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine("배열의 합 : " + sumNumbers);*/

		}
    }
}
