using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study15
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int AddArrow(int a, int b) => a + b;
        
        static void PrintMessage()
        {
            Console.WriteLine("안녕하세요");
        }

        static void PrintmassageArrow() => Console.WriteLine("안녕하세요!");

		static void Main(string[] args)
        {

            Console.WriteLine(Add(3, 5));
            Console.WriteLine(AddArrow(3, 5));

            PrintMessage();
            PrintmassageArrow();
        }
    }
}
