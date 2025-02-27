using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study18
{
    class Program
    {

        struct Rectangle
        {
            public int Width;
            public int Height;

            public int GetArea() => Width * Height;
        }

        struct Point
        {
            public int x;
            public int y;
        }

        struct Student
        {
            private string Name;
			private int KorScore;
			private int EngScore;
			private int MathScore;

            public void SetName(string name) => Name = name;
            public void SetKorScore(int score) => KorScore = score;
            public void SetEngScore(int score) => EngScore = score;
            public void SetMathScore(int score) => MathScore = score;

            public string GetName()
            {
                return Name;
            }

            public int GetKorScore()
            {
                return KorScore;
            }

			public int GetEngScore()
			{
				return EngScore;
			}

			public int GetMathScore()
			{
				return MathScore;
			}
		}

        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            for(int i = 0; i < 3; i++)
            {
                Console.Write("학생의 이름을 입력하세요 : ");
                students[i].SetName(Console.ReadLine());
				Console.Write("학생의 국어점수를 입력하세요 : ");
				students[i].SetKorScore(int.Parse(Console.ReadLine()));
				Console.Write("학생의 영어점수를 입력하세요 : ");
				students[i].SetEngScore(int.Parse(Console.ReadLine()));
				Console.Write("학생의 수학점수를 입력하세요 : ");
				students[i].SetMathScore(int.Parse(Console.ReadLine()));
			}

            Console.Clear();
            Console.WriteLine("이름     국어   영어   수학");

			for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{students[i].GetName()}       {students[i].GetKorScore()}     {students[i].GetEngScore()}     {students[i].GetMathScore()}");
            }

			/*var rect = new Rectangle { Width = 5, Height = 4 };

            Console.WriteLine($"Area : {rect.GetArea()}");*/

				/*Point[] points = new Point[2];

				points[0].x = 10;
				points[0].y = 10;

				points[1].x = 20;
				points[1].y = 20;

				foreach(var point in points)
				{
					Console.WriteLine($"Point : ({point.x}, {point.y})");
				}*/
		}
    }
}
