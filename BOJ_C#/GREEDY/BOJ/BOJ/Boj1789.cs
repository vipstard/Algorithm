using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj1789
    {
        static void Main(String[] args)
        {
            int result = 0;

            for (int i = 1; i <= 20; i++)
            {
                result += i;
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
