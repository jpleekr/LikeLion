using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static int Add(int a, int b)
        {
            int sum = a + b;

            return sum;
        }

        static int StringLenght(string str)
        {
            int lenght = 0;

            foreach(char cha in str)
            {
                lenght++;
            }

            return lenght;
        }

        static int MaxNum(int a, int b, int c)
        {
            int max = 0;

            if (a >= b)
                max = (a >= c) ? a : c;
            else
                max = (b >= c) ? b : c;

            return max;
        }

        static void Main(string[] args)
        {

            //문제 1
            int[] integers = new int[] { 10, 20, 30, 40, 50 };

            /*for (int i = 0; i < integers.Length; i++)
            {
                Console.Write($"{integers[i]} ");
            }*/

            //문제 2
            /*int sum = 0;

            Console.WriteLine("\n숫자 입력 :  ");

            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
                sum += integers[i];
            }

            Console.WriteLine("총 합 :  " + sum);*/

            //문제 3
            /*int[] max = new int[] { 3, 8, 15, 6, 2 };
            int maxNum = 0;

            for (int i = 0; i < max.Length; i++)
            {
                maxNum = (maxNum > max[i]) ? maxNum : max[i];
            }

            Console.WriteLine("최대값 :  " + maxNum);*/

            //문제 4
            /*for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + " ");
            }*/

            //문제 5
            /*int num = 0;

            while (true)
            {
                num++;

                if (num > 10) break;

                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }

            }*/

            //문제 6
            /*int[] oneToFive = new int[] { 1, 2, 3, 4, 5 };

            foreach (int integer in oneToFive)
            {
                Console.Write(integer + " ");
            }*/

            //문제 7
            /*int x = 0, y = 0;

            Console.WriteLine("두 정수 입력 : ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());


            int add = Add(x, y);

            Console.WriteLine($"{x}과 {y}의 합 : {add}");*/

            //문제 8
            /*string str;

            Console.Write("문자열 입력 : ");
            str = Console.ReadLine();

            Console.Write("문자열 길이 : " + StringLenght(str));*/

            /*static int StringLenght(string str)
			{
				int lenght = 0;

				foreach (char cha in str)
				{
					lenght++;
				}

				return lenght;
			}*/

            //문제 9
            /*int num1 = 0, num2 = 0, num3 = 0, numMax = 0;

            Console.WriteLine("세 정수 입력 : ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            numMax = MaxNum(num1, num2, num3);

            Console.WriteLine("가장 큰 수 : " + numMax);*/

            /*static int MaxNum(int a, int b, int c)
			{
				int max = 0;

				if (a >= b)
					max = (a >= c) ? a : c;
				else 
					max = (b >= c) ? b : c;

				return max;
			}*/
        }
    }
}
