using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj2839
    {
        static void Main(String[] args)
        {
         
            int n = Convert.ToInt32(Console.ReadLine());
            int result = n;
            int start = n / 5;
            int n2 = 0;
            int n3 = 0;
            bool check = false;

            for (int i = start; i >= 0; i--)
            {

                n2 = (n-(i*5)) % 3;
                n3 =  (n - (i * 5)) / 3 + i;

                if (n2 == 0 && result > n3)
                {
                    result = n3;
                    check = true;
                }

                if (!check) result = n;
            }

            if (result == n) result = -1;

            Console.WriteLine(result);
        }

        // 너무어렵게 풀었다..... 더 쉬운방법이 있을거야
    }
}
