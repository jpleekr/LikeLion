using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요! MyNamespace의 MyClass입니다");
        }
    }
}

namespace study14
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("SayHello");
        }

        /*static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach(int num in numbers)
            {
                total += num;
            }

            return total;
        }*/ 

       /*static int Factorial(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("*" + n);
                return 1;
            }

            Console.WriteLine("*" + n);

            return n * Factorial(n - 1);
        }*/

        static void Main(string[] args)
        {
            SayHello();
            dev1.MyClass.SayHello();

            //Console.WriteLine(Factorial(5));

            /*Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));*/

            
        }
    }
}
