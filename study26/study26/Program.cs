using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] names = { "Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n);

            foreach(var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            var firstName = names.First(n => n.StartsWith("A"));

            Console.WriteLine($"First name starting with A: {firstName}");*/

            /*int[] nums = { 5, 3, 8, 1 };

            var sortedMeshod = nums.OrderBy(n => n);

            var sortedQuery = from n in nums
                              orderby n
                              select n;

            Console.WriteLine("Meshod syntax : ");
            foreach (var n in sortedMeshod)
                Console.WriteLine(n);

			Console.WriteLine("Query syntax : ");
			foreach (var n in sortedQuery)
				Console.WriteLine(n);*/

            /*string[] words = { "apple", "banana", "cherry" };

            var lengths = words.Select(w => w.Length);

            foreach(var legth in lengths)
            {
                Console.WriteLine(legth);
            }

            var upperWords = words.Select(w => w.ToUpper());

			foreach (var word in upperWords)
			{
				Console.WriteLine(word);
			}*/

            /*int[] data = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach(var d in data)
            {
                sum += d;
            }

            Console.WriteLine($"Sum : {sum}");*/

            /*int[] data = { 1, 2, 3, 4, 5 };
            int count = data.Length;

			Console.WriteLine($"Count : {count}");

            double avg = data.Average();
			Console.WriteLine($"Average : {avg}");

            int max = data.Max();
			Console.WriteLine($"Max : {max}");

            int min = data.Min();
			Console.WriteLine($"Min : {min}");*/

            /*int[] data = { 10, 12, 20, 25, 30 };
            int target = 22;
            int nearest = data[0];

            foreach(var d in data)
            {
                if (Math.Abs(d - target) < Math.Abs(nearest - target))
                    nearest = d;
            }

            Console.WriteLine($"Nearest to {target} : {nearest}");*/

            /*int[] scores = { 90, 70, 50, 70, 60 };

            for(int i = 0; i < scores.Length; i++)
            {
                int rank = 1;

                for(int j = 0; j < scores.Length; j++)
                {
                    if (scores[j] > scores[i])
                        rank++;
                }
                Console.WriteLine($"Score : {scores[i]}, Rank : {rank}");
            }*/

            /*int[] data = { 5, 2, 8, 1, 9 };
            Array.Sort(data);

            foreach (var d in data)
                Console.WriteLine(d);*/

            /*int[] data = { 5, 2, 8, 1, 9 };
            int target = 8;
            int index = -1;

            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index >= 0 ? $"Found at index{index}" : "Not found");*/

            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };

            var groups = fruits.GroupBy(f => f[0]);

            foreach(var group in groups)
            {
                Console.WriteLine($"Key : {group.Key}");
                foreach(var item in group)
                {
                    Console.WriteLine($" {item}");
                }
            }

		}
    }
}
