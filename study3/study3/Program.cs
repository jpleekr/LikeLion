using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study3
{
    class Program
    {
        static void Main(string[] args)
        {
            int HP = 100;
            float att = 56.7f;
            string name = "??";
            char rank = 'S';

            Console.WriteLine("캐릭터");
            Console.WriteLine("체력 : "+HP);
            Console.WriteLine("공격력 : "+att);
            Console.WriteLine("캐릭터이름 : "+name);
            Console.WriteLine("등급 : "+rank);
        }
    }
}
