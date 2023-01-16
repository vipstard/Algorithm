using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj1026_2
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] intArray1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] intArray2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int result = 0;
            Array.Sort(intArray1); 
            
            for (int i = 0; i < n; i++)
            {
                int max = 0;

                for (int j = 0; j < n; j++)
                {
                    if (max < intArray2[j])
                    {
                        max = intArray2[j];
                    }
                }

                int idx = Array.IndexOf(intArray2, max);
                if (idx != -1)
                {
                    intArray2[idx] = 0;
                }
                
                result += max * intArray1[i];
            }

            Console.WriteLine(result);
        }
    }
}
