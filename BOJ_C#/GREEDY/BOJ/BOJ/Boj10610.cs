using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
	// 30
	public class Boj10610
	{
		static void Main(String[] args)
		{
			StringBuilder sb = new StringBuilder();
			String st = "";
			List<int> numList = new List<int>();

            foreach (char c in Console.ReadLine().ToString())
            {
                numList.Add(int.Parse(c.ToString()));
            }

			numList.Sort((a,b) =>b.CompareTo(a));
			
			foreach(int s in numList)
			{
				st += s.ToString();
			}

            if ((long.Parse(st)) %30 == 0)
			{
				Console.WriteLine(st);
			}
			else
			{
				Console.WriteLine(-1);
			}
		}
	}
}
