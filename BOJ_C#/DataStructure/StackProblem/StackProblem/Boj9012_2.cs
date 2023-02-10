using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblem
{
	public class Boj9012_2
	{
		static void Main(string[] args){
			int n = Convert.ToInt32(Console.ReadLine());
			String str;

				for (int i = 0; i<n; i++)
			{
				str = Console.ReadLine();
					
				while (str.Contains("()"))
					str = str.Replace("()", "");

				if (str =="") Console.WriteLine("YES");
				else Console.WriteLine("NO");
			}
		}
	}
}
