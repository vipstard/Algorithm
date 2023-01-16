using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    // 동전 0 
    public class Boj11047
    {
        static void Main(String[] args)
        {
            List<int> intList = new List<int>();
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int n = nums[0];
            int k = nums[1];
            int money, result = 0;
            

            for (int i = 0; i < n; i++)
            {
                intList.Add(Convert.ToInt32(Console.ReadLine())); 
            }

            // 오름차순으로 정렬된 상태로 입력되기 때문에  최소값을 얻기위해 큰 수부터
            // 필터링 해야하므로 뒤집어준다.
            intList.Reverse();

            for (int i = 0; i < n; i++)
            {
                money = k / intList[i];

                if (money > 0)
                {
                    k -= money * intList[i];
                    result += money;
                }
            }

            Console.WriteLine(result);
            

        }
    }
}
