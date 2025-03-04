using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study23
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int valueType = 10;
            object referncceType = valueType;

            valueType = 20;

            Console.WriteLine($"ValueType : {valueType}");
            Console.WriteLine($"ReferenceType : {referncceType  }");*/

            /*int value = 42;
            object boxed = value;
            int unboxed = (int)boxed;

            Console.WriteLine($"Boxed : {boxed}, Unboxed : {unboxed}");*/

            /*object obj = "Hello";

            Console.WriteLine(obj is string);
            Console.WriteLine(obj is int);*/

            /*object obj = "Hello";
            string str = obj as string;

            Console.WriteLine(obj is string);*/

            /*var obj = 42;

            if (obj is int number)
            {
                Console.WriteLine($"Number : {number}");
            }
            else
            {
                Console.WriteLine("Not a Number");
            }*/

            /*string greeting = "Hello";
            string name = "Alice";

            string message = greeting + "," + name + "!";

            Console.WriteLine(message);

            Console.WriteLine($"Length of name : {name.Length}");
            Console.WriteLine($"To Upper : {name.ToUpper()}");
            Console.WriteLine($"Substring : {name.Substring(1)}");*/

            /*string text = "C# is awesome!";
            Console.WriteLine($"Cotaine 'awesome' : {text.Contains("awesome")}");
            Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome","great")}");*/

            /*StringBuilder sb = new StringBuilder("Hello");
            sb.Append(",");
            sb.Append("World!");

            Console.WriteLine(sb.ToString());*/

            /*int iterations = 10000;

            Stopwatch sw = Stopwatch.StartNew();

            string text = "";

            for(int i = 0; i < iterations; i++)
            {
                text += "a";
            }

            sw.Stop();
            Console.WriteLine($"String : {sw.ElapsedMilliseconds}ms");

		    sw = Stopwatch.StartNew();

            StringBuilder sb = new StringBuilder();

			for (int i = 0; i < iterations; i++)
			{
                sb.Append("a");
			}

			sw.Stop();
			Console.WriteLine($"String : {sw.ElapsedMilliseconds}ms");*/

            /* while(true)
             {
                 try
                 {
                     int[] number = { 1, 2, 3 };
                     Console.WriteLine(number[5]);
                 }
                 catch(IndexOutOfRangeException ex)
                 {
                     Console.WriteLine($"Error : {ex.Message}");
                 }
             }*/

            /*while(true)
            {
                try
                {
                    int number = int.Parse("NotANumber");
                }
                catch(FormatException ex)
                {
                    Console.WriteLine($"Format Error : {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("항상 싱행됩니다.");
                }
            }*/

            /*try
            {
                int number = int.Parse("abc");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"General Error : {ex.Message}");
            }*/

            /*try
            {
                int age = -5;
                if(age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"General Error : {ex.Message}");
            }*/


		}
    }
}
