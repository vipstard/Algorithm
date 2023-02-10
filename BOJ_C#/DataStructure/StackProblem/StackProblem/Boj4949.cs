using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BOJ
{
	// 균형잡힌 세상
	public class Boj4949
	{
		static void Main(String[] args)
		{
			String str = @"[^()\[\]]";
			String input="";

			while (true)
			{
				input = Console.ReadLine();
				if (input == ".") break;

				input = Regex.Replace(input, str, "");

				while (input.Contains("()") || input.Contains("[]"))
				{
					if(input.Contains("()")) input = input.Replace("()", "");
					if(input.Contains("[]")) input = input.Replace("[]", "");

					input =( input == "" ? "YES" : "NO");
				}

				Console.WriteLine(input);
			}
		}
	}
}
