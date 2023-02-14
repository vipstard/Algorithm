using System.Text.RegularExpressions;

namespace BOJ
{
	// 균형잡힌 세상
	public class Boj4949
	{
		static void Main(String[] args)
		{
			String pattern = @"[^()\[\]]";
			String input="";

			while (true)
			{
				input=Console.ReadLine();
				if (input == ".") break;
				input = Regex.Replace(input, pattern, "");
				Console.WriteLine(input);
				while (input.Contains("()") || input.Contains("[]"))
				{
					if(input.Contains("()")) input = input.Replace("()", "");
					if(input.Contains("[]")) input = input.Replace("[]", "");

				}
				input = (input == "" ? "yes" : "no");
				Console.WriteLine(input);

			}
		}
	}
}
