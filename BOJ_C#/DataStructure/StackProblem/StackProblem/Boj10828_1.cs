using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblem
{
    // 스택
    // string Builder 사용
    public class Boj10828_1
    {
        static void Main(String[] args)
        {
            Stack stack = new Stack();

            int n = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                if (command.Contains(" "))
                {
                    String[] strArr = command.Split();

                    if (strArr[0] == "push")
                    {
                        stack.Push(strArr[1]);
                    }
                }
                else
                {
                    string result = "";

                    if (command == "pop")
                    {
                        if (stack.Count <= 0) result = "-1";
                        else result = stack.Pop().ToString();
                    }
                    else if (command == "size") result = stack.Count.ToString();
                    else if (command == "empty") result = stack.Count <= 0 ? "1" : "0";
                    else if (command == "top")
                    {
                        if (stack.Count <= 0) result = "-1";
                        else result = stack.Peek().ToString();
                    }

                    sb.AppendLine(result);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
