using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study17
{
    class Program
    {

        struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Print()
            {
                Console.WriteLine($"좌표 :  {X} , {Y}");
            }
        }

        static void Main(string[] args)
        {
            Point p1 = new Point(5, 15);

            p1.Print();

        }
    }
}
