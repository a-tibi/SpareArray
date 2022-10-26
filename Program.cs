using System;
using System.Collections.Generic;

namespace SpareArray
{
	class Program
	{
		public static List<int> matchingStrings(List<string> strings, List<string> queries)
		{
			var result = new List<int>();

			foreach (var q in queries)
			{
				int freq = 0;
				foreach (var s in strings)
				{
					if (q == s)
						freq++;
				}
				result.Add(freq);
			}

			return result;
		}

		static void Main(string[] args)
		{
			Console.Write("Enter number of Strings: ");
			int n = Convert.ToInt32(Console.ReadLine());

			var strings = new List<string>();
			for (int i = 0; i < n; i++)
			{
				Console.Write($"String {i + 1}: ");
				strings.Add(Console.ReadLine());
			}

			Console.Write("Enter number of Queries: ");
			int q = Convert.ToInt32(Console.ReadLine());

			var queries = new List<string>();
			for (int i = 0; i < q; i++)
			{
				Console.Write($"Queries {i + 1}: ");
				queries.Add(Console.ReadLine());
			}

			var res = matchingStrings(strings, queries);

			foreach (var item in res)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}
	}
}
