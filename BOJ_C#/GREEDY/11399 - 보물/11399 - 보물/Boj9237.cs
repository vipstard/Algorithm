using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    internal class Boj9237
    {
        static void Main(String[] args)
        {
            // 입력받기 
            int n = Convert.ToInt32(Console.ReadLine());
            String[] arr = Console.ReadLine().Split();
            
            //입력받은 배열 int형 배열로 변환
            int[] intArr = arr.Select(x => Convert.ToInt32(x)).ToArray();
            
            // 배열 내림차순으로 정렬
            Array.Sort(intArr);
            Array.Reverse(intArr);

            int result = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                // 첫째날을 시작으로 i 값과 첫째날 묘목이 자라는 시간을 더한다.
                if (result < (i+1) + intArr[i]) result = (i+1) + intArr[i] ;
            }

            Console.WriteLine(result+1);
        }
    }
}
