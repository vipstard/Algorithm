using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
	// 30
    // 3의 배수 조건 과 10의 배수 조건을 충족시켜야 한다.
    // 3의 배수 => 각 자릿수 합이 3의 배수이여야 한다. ex) 219 => 2+1+9 = 12 는 3의 배수이다.
    // 10의 배수 자릿수 중에 0 이 포함되어 있어야 한다.
	public class Boj10610
	{
        static void Main(String[] args)
        {
            StringBuilder sb = new StringBuilder();
            List<int> list = new List<int>();
            String N = Console.ReadLine();
            

            for (int i = 0; i < N.Length; i++)
            {
                list.Add(Int32.Parse(N.Substring(i,1)));
            }
            
            // list 에 0이 포함되어있지 않거나 리스트 요소(각 자릿수) 합이 3의 배수가 아니면 -1을 출력한다.
            if (!(list.Contains(0)) || !(list.Sum() % 3 == 0))
            {
                Console.WriteLine(-1);
            }
            else
            {
                // 조건에 만족하면 내림차순으로 정렬하고 출력한다.
                list.Sort(new Comparison<int>((n1, n2) => n2.CompareTo(n1)));

                foreach (var i in list)
                {
                    sb.Append(i);
                }

                Console.WriteLine(sb.ToString());
            }

           

        }
    }
}
