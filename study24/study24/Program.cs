using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = { 1, 2, 3, 4, 5 };

            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }*/

            /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            names.Add("Dave");
            names.Remove("Bob");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }*/

            /*List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine(list[1]);
            list.Insert(1, 100);
            Console.WriteLine(list[1]);

            Console.WriteLine(list[0]);
            Console.WriteLine(list.Count);

            list[2] = 200;

			foreach (int i in list)
			{
				Console.WriteLine(i);
			}*/

            /*Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }*/

            /*Queue queue = new Queue();

            queue.Enqueue("q");
            queue.Enqueue("w");
            queue.Enqueue("e");
            queue.Enqueue("r");
            queue.Enqueue("점멸");
            queue.Enqueue("평타");

			while (queue.Count > 0)
			{
				Console.WriteLine(queue.Dequeue());
			}*/

            /*ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);

            Console.WriteLine("ArrayList 요소 : ");

            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Remove(1);

            Console.WriteLine("\nArrayList 요소 제거 후 : ");

			foreach (var item in arrayList)
			{
				Console.WriteLine(item);
			}*/

            /*Hashtable hashtable = new Hashtable();

            hashtable["Alice"] = 25;
            hashtable["Bob"] = 30;
            hashtable["포션"] = 20;

            Console.WriteLine("Hashtable 요소 : ");

            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            }

            Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");

            hashtable.Remove("Bob");

            Console.WriteLine("Hashtable 요소 : ");

			foreach (DictionaryEntry entry in hashtable)
			{
				Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
			}*/

             

		}
    }
}
