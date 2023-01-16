using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj1026_1
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

           List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
           List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            list1.Sort();
            
           int result = 0;

           for (int i = 0; i < n; i++)
           {
               result += list1[i] * list2.Max();
               list2.Remove(list2.Max());
           }

           Console.WriteLine(result);
        }
    }
}
