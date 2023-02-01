using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// BOJ10773 제로
namespace StackProblem
{
    public class Boj10773
    {
        static void Main(String[] args)
        {
            Stack<int> stack = new Stack<int>();

            int n = Convert.ToInt32(Console.ReadLine());
            int m=0;

            for (int i = 0; i < n; i++) 
            {
                m=Convert.ToInt32( Console.ReadLine());

                if (m == 0 && stack.Count>0)
                {
                    stack.Pop();
                }

                if(m != 0)
                {
                    stack.Push(m);
                }
            }

            Console.WriteLine(stack.Sum());
        }

    }
}
