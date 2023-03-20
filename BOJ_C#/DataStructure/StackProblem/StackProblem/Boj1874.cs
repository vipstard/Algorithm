using System.Text;

namespace StackProblem
{
	// 스택 수열 23.03.14 Fail
	public class Boj1874
	{
		 static void Main(String[] args)
		{
            StringBuilder sb = new StringBuilder();
			Stack<int> stack = new Stack<int>();

            int len = int.Parse(Console.ReadLine());
			int[] Arr = new int[len];
			
			for(int i=0; i<len; i++) Arr[i] = int.Parse(Console.ReadLine());

			int cnt = 0;
			int idx = 1;
			stack.Push(idx);
			sb.Append("+\n"); 

			while(cnt != len)
			{
				while (true)
				{
					if(stack.Count != 0 && Arr[cnt] == stack.Peek())
					{
						int pop = stack.Pop();
						sb.Append("-\n");
						idx = pop > idx? pop : idx;
						break;
					}
					else
					{
						idx++;
						stack.Push(idx);
						sb.Append("+\n");
					}
					if( idx > len)
					{
						Console.WriteLine("NO");
						return;
					}
				}
				cnt++;
			}
			Console.WriteLine(sb.ToString());
            

        }
	}
}
