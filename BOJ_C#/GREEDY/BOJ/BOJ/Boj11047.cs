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
