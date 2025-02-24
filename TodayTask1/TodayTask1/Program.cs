using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask1
{
    class Program
    {
		public static void ConsoleEnter()
		{
			Console.ReadLine();
			Console.Clear();
		}

        static void Main(string[] args)
        {
			char[] arrLoading = new char[10];

			for (int i = 0; i < 10; i++)
			{
				arrLoading[i] = '□';
			}

			Console.WriteLine(arrLoading);
			Thread.Sleep(1000);
			Console.Clear();

			for (int i = 0; i < 10; i++)
			{
				arrLoading[i] = '■';
				Console.WriteLine(arrLoading);
				Thread.Sleep(1000);
				Console.Clear();
			}

			Console.WriteLine("엔터를 치면 스토리가 시작함니다.");
			ConsoleEnter();


			Console.WriteLine("하루가 시작되었다.");
			ConsoleEnter();

			Console.WriteLine("나는 배를 타고 세게여행을하다 태풍을 만나 어느 외딴섬에 표류하게 되었다.");
			ConsoleEnter();

			Console.WriteLine("이섬에서 표류한지 이틀이 지났다.나는 과연 이섬에서 살아남을 수 있을까?");
			ConsoleEnter();

			Console.WriteLine("라고 써져있는 메모장이 우리집 우편함에 놓여져있었다.");
			ConsoleEnter();

			Console.WriteLine("다음이야기는 업데이트를 기다려 주세요^^");
		}
    }
}
