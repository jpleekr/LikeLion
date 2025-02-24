using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string greeting;
            greeting = "Hello, World";

            Console.WriteLine(greeting);*/

            /*int score = 100;
            double temperature = 36.5;
            string city = "Seoul";

            Console.WriteLine(score);
            Console.WriteLine(temperature);
            Console.WriteLine(city);*/

            /*int x = 10, y = 20, z = 30;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);*/

            /*const double Pi = 3.14159;
            const int MaxScore = 100;

            Console.WriteLine("Pi : " + Pi);
            Console.WriteLine("Max Score : " + MaxScore);*/
            int nAtt = 16755, nMaxHp = 78103, nSpecial = 1017, nSubdue = 41, nSwiftness = 611, nPatience = 22,
            nPractice = 39;
            double dCritical = 36.0;

            Console.WriteLine("기본특성");
            Console.WriteLine("공격력 : "+nAtt);
            Console.WriteLine("최대 생명력 : "+ nMaxHp);
            Console.WriteLine("전투특성");
            Console.WriteLine("치명 : "+ dCritical);
            Console.WriteLine("특화 : "+ nSpecial);
            Console.WriteLine("제압 : "+ nSubdue);
            Console.WriteLine("신속 : "+ nSwiftness);
            Console.WriteLine("인내 : "+ nPatience);
            Console.WriteLine("숙련 : "+ nPractice);

		}
    }
}
