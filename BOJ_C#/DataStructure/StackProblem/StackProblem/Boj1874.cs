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
			
			// len 개의 수열을 입력받아서 Arr 배열에 저장
			for(int i=0; i<len; i++) Arr[i] = int.Parse(Console.ReadLine());

			int ArrIdx = 0;
			int num = 1; // 1 2 3 ~ 순으로 저장 해야하니까 1부터 시작한다.
			stack.Push(num);
			sb.AppendLine("+");

			while(ArrIdx !=len)
			{
				while (true)
				{
					if (stack.Count > 0 && Arr[ArrIdx] == stack.Peek())
					{
						int pop = stack.Pop();
						sb.AppendLine("-");
						num = pop > num ? pop : num;
						break;
					}
					else
					{
						stack.Push(++num);
						sb.AppendLine("+");
					}
					if(num > len)
					{
						Console.WriteLine("NO");
						return;
					}
				}
				ArrIdx++;
			}
			Console.WriteLine(sb.ToString());
		}
	}
}
