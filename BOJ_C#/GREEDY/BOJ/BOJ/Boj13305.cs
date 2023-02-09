using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
	// 그리디 주유소
	public class Boj13305
	{
		static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] distants = new int[n - 1];
			int[] price = new int[n];

			int distant = 0;
			int result = 0;

			distants = Console.ReadLine().Split().Select(int.Parse).ToArray();
			price = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int cnt = 0;
			int min = price[0];

			for (int i = 0; i < price.Length - 1; i++)
			{
				for (int j = i + 1; j < price.Length; j++)
				{
					distant += distants[j - 1];
					if (min >= price[j])
					{
						cnt += distant;
						if (cnt <= distants.Sum()) result += price[i] * distant;
						distant = 0;
						min = price[j];
						break;
					}
				}
			}
			Console.WriteLine(result);
		}
	}
}