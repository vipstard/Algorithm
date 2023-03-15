namespace StackProblem
{
	// 스택 수열 23.03.14
	public class Boj1874
	{
		static void Main(String[] args)
		{
			List<int> list1 = new List<int>(); // 수열 담은 리스트
			List<int> list2 = new List<int>(); // 1~n 의 수 담은 리스트
			Stack<int> stack = new Stack<int>();
			int n = Convert.ToInt32(Console.ReadLine());
		
			for(int i =1; i<=n; i++)
			{
				list1.Add(Convert.ToInt32(Console.ReadLine()));
				list2.Add(i);
			}

			for(int i=0; i<n; i++) // 4 3 6 8 7 5 2 1
			{
				if (stack.Count > 0 && stack.Peek() == list1[i-1])
				{
					stack.Pop();
					Console.WriteLine("- ");
				}

				foreach (int l2 in list2) { // 1 2 3 4 5 6 7 8
					stack.Push(l2);
					Console.Write("+ ");
					if (list1[i] == l2) break;
				}

			
			}

			// Debug
			foreach (var s in stack)
			{
				Console.Write(s + " ");
			}

			foreach (var i in list1)
			{
				Console.Write(i +" ");
			}
		}
	}
}
