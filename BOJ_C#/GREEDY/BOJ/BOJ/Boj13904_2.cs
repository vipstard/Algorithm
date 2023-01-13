using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj13904_2
    {
        static void Main(String[] args)
        {
            int result = 0;
            int startVal = 0;
            int maxVal;
            int idx = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            int[] intArr;


            List<int[]> list = new List<int[]>();
            List<int> list2 = new List<int>();


            for (int i = 0; i < n; i++)
            {
                intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (intArr[0] > startVal) startVal = intArr[0];

                list.Add(intArr);
            }

            var sortedFirst = list.OrderByDescending(x => x[0]);
            var sortedArr = sortedFirst.ToArray();


            for (int i = startVal; i > 0; i--)
            {
                maxVal = 0;

                for (int j = 0; j < n; j++)
                {

                    if (sortedArr[j][0] >= i)
                    {
                        list2.Add(sortedArr[j][1]);
                    }
                }

                if (list2.Count != 0) maxVal = list2.Max();

                result += maxVal;

                for (int k = 0; k < n; k++)
                {
                    if (sortedArr[k][1] == maxVal)
                    {
                        sortedArr[k][0] = 0;
                        sortedArr[k][1] = 0;
                        break;
                    }
                }

                list2.Clear();
            }


            Console.WriteLine(result);
        }
    }
}
