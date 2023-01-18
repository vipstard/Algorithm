using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj10162
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArr1 = { 300, 60, 10 };
            int[] intArr2 = new int[3];

            if (n % 10 == 0)
            {
                for (int i = 0; i < intArr1.Length; i++)
                {
                    intArr2[i] = n / intArr1[i];
                    n %= intArr1[i];
                }

                foreach (var i in intArr2)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                Console.WriteLine(-1);
            }

          
        }
    }
}
