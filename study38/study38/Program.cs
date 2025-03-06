using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study38
{
    /*class MyResource
    {
        ~MyResource()
        {
            Console.WriteLine("삭제될때 호출");
        }
    }*/

    class Program
    {
        static void Increase(ref int x)
        {
            x++;
        }

        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
        }


        static void Main(string[] args)
        {
            /*MyResource r = new MyResource();*/
            int a = 10;
            int b = 20;
            int x, y;

            Increase(ref a);

            Console.WriteLine(a);

            OutFunc(a, b,out x,out y);

            Console.WriteLine($"{x}, {y}");

        }
    }
}
