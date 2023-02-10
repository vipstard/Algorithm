using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 괄호
namespace StackProblem
{
	internal class Boj9012_1
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] strArr = new string[n];

			for (int i = 0; i < n; i++) strArr[i] = Console.ReadLine();

			for (int j = 0; j < strArr.Length; j++)
			{
				while (strArr[j].Contains("()")) 
					strArr[j] = strArr[j].Replace("()", "");

				if (strArr[j]=="") Console.WriteLine("YES");
				else Console.WriteLine("NO");
			}
		}

	}
}
