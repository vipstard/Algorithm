namespace StackProblem
{
    public class Boj10828_2
    {
        // 스택
        // StreamWriter 사용
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            using StreamWriter stream = new StreamWriter(Console.OpenStandardOutput());

            for (int i = 0; i < n; i++)
            {
                String command = Console.ReadLine();

                if(command.Contains("push"))
                    stack.Push(Convert.ToInt32(command[5..]));
                
                else
                    switch (command)
                    {
                        case "pop":
                            stream.WriteLine(stack.Count ==0?-1 : stack.Pop());
                            break;
                        case "size":
                            stream.WriteLine(stack.Count);
                            break;
                        case "empty":
                            stream.WriteLine(stack.Count == 0 ? 1 : 0);
                            break;
                        case "top":
                            stream.WriteLine(stack.Count ==0? -1 : stack.Peek());
                            break;
                    }
            }
        }
    }
}
