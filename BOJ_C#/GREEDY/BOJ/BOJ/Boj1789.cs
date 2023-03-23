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
            long result = 0;
            long num = 1;
            long n = long.Parse(Console.ReadLine());

            while (true)
            {
               
                result += num;
                
                if (result > n)
                {
                    Console.WriteLine(--num);
                    break;
                }

                num++;
                
            } 
        }
    }
}
