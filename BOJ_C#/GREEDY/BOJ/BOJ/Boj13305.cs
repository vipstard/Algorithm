using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    // 그리디 주유소
    public class Boj13305
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] distant=new int[n];
            int[] price=new int[n];


            distant = Console.ReadLine().Split().Select(int.Parse).ToArray();
            price = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < price.Length-1; i++)
            {

            }
        }
    }
}
