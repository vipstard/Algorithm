using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj2217
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int[] intArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(intArr);
            Array.Reverse(intArr);
            
            // 내림차순 정렬을 한 후 i번째 값(로프가 들수있는 최대중량) 과 로프의 개수를 곱하면 최대중량이 나온다.
            for (int i = 0; i < intArr.Length; i++)
            {
                if (result < intArr[i] * (i + 1))
                {
                    result = intArr[i] * (i + 1);
                }
            }
            Console.WriteLine(result);
        }
    }
}
