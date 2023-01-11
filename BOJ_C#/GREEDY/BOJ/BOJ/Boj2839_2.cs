using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    internal class Boj2839_2
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            while (n>=0)
            {
                if (n % 5 == 0)
                {
                    result += n / 5;
                    Console.WriteLine(result);
                    break;
                }

                // 3키로 씩 빼면서 봉지를 1개씩 증가시킨다.
                n -= 3;
                result += 1;

                // 3키로봉지를 빼다보면 n%5 조건문에 걸려서 break 되거나 n=0에 딱 맞아서 반복문이 중지된다.
                // 정확히 무게가 맞지 않으면 n이 -가 되는데 이때 -1을 출력한다.
                if (n < 0)
                {
                    result = -1;
                    Console.WriteLine(result);
                    break;
                }
            }
        }
    }
}
