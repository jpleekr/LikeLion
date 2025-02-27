using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study16
{
    class Program
    {

        enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }

        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        static void ChooseWeapon(WeaponType weapon)
        {
            switch((int)weapon)
            {
                case 0:
                    Console.WriteLine("검을 선택했습니다");
                    break;
				case 1:
					Console.WriteLine("활을 선택했습니다");
					break;
				case 2:
					Console.WriteLine("지팡이을 선택했습니다");
					break;
			}
        }

        static void Main(string[] args)
        {
            WeaponType weapon = WeaponType.Bow;

            ChooseWeapon(weapon);


            /*DayOfWeek today = DayOfWeek.Wednesday;

            Console.WriteLine(today);
            Console.WriteLine((int)today);

            StatusCode status = StatusCode.NotFound;

			Console.WriteLine(status);
			Console.WriteLine((int)status);*/

			/*Console.WriteLine($"Pi : {Math.PI}");
            Console.WriteLine($"Square root of 25 : {Math.Sqrt(25)}");
            Console.WriteLine($"Power (2^3) : {Math.Pow(2, 3)}");
            Console.WriteLine($"Round(3.75) : {Math.Round(3.75)}");*/

		}
    }
}
