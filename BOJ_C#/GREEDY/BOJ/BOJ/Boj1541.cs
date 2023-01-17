using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj1541
    {
        // 최소 값을 얻기 위해서는 +를 먼저하고 -를 해주면 최소값이 된다.
        static void Main(String[] args)
        {
            int result = 0;
            List<String> a = new List<string>();
            String aa = Console.ReadLine();

            // 문자열에 - 가 포함된 경우
            if (aa.Contains("-"))
            {
                // -를 기준으로 분리하고 List에 넣어준다.
                a = aa.Split("-").ToList();

                
                // 각 요소들에 + 가 있으면 안에있는 수들을 더해준다.
                for (int i = 0; i < a.Count; i++)
                {
                    a[i] = a[i].Split("+").Select(int.Parse).Sum().ToString();

                    // 0번 요소를 제외하고 -를 붙여준다.
                    if (i > 0)  a[i] = "-" + a[i];
                }
            }
            // 문자열에 +만 있는 경우
            else
            {
                a = aa.Split("+").ToList();
            }

            // 계산된 리스트를 모두 더함
            result = a.Select(int.Parse).Sum();

            Console.WriteLine(result);
        }

    }
}
