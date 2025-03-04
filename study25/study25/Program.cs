using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study25
{
	/*class Cup<T>
    {
        public T Content { get; set; }
    }*/

	/*class SimpleCollection : IEnumerator<int>
    {
        private int[] data = { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach(var item in data)
            {
                yield return item;
            }
        }
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	}*/

	class Program
    {
        static void Main(string[] args)
        {
            /*var collectiom = new SimpleCollection();

            foreach(var i in collectiom)
            {
                Console.WriteLine(i);
            }*/

            /*Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            Console.WriteLine($"cupOfString : {cupOfString.Content}");
            Console.WriteLine($"cupOfInt : {cupOfInt.Content}");*/

            /*Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Dave");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }*/

            //IEnumerator
            //C#컬렉션 순회 반복할 수 있는 인터페이스

            /*ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            IEnumerator enumerator = list.GetEnumerator();

            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }*/

            /*Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["금도끼"] = 10;
            ages["은도끼"] = 5;
            ages["돌도끼"] = 1;

            foreach(var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }*/

            /*string str = null;

            if(str == null)
            {
                Console.WriteLine("str is null");
            }*/

            /*int? nullablInt = null;

            Console.WriteLine(nullablInt.HasValue ? nullablInt.Value.ToString() : "No value");

            nullablInt = 10;

            Console.WriteLine(nullablInt.HasValue ? nullablInt.Value.ToString() : "No value");*/

            /*//null 값을 다루는 연산자 ?? ?. 연산자
            //?? 연산자를 사용해 null인 경우 대체값을 제공하고 ?.은 null안전 접근을 합니다

            string str = null;

            Console.WriteLine(str ?? "DefaultValue");//str이 null이면 "DefaultValue"

            Console.WriteLine(str?.Length);//str이 null이므로 길이출력X

			str = "Hello";

            Console.WriteLine(str?.Length);//str이 null이 아니므로 길이출력*/

            /*int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }*/

		}


	}
}
