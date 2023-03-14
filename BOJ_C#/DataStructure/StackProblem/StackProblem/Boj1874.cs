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

			foreach(var l1 in list1)
			{
				foreach(int l2 in list2)
					if(l1== l2)
					{
						stack.Push(l2);
						stack.Pop();

						Console.Write("+ ");
						Console.Write("- ");
					}
					else
					{
						stack.Push(l2);
						list2.RemoveAt(l2);
						Console.Write("+ ");
					}
				
			}

			// Debug
			foreach (var s in stack)
			{
				Console.Write(s + " ");
			}

			foreach (var i in list)
			{
				Console.Write(i +" ");
			}
		}
	}
}
