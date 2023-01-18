using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj5585
    {
        static void Main(String[] args)
        {
            int[] money = { 500, 100, 50, 10, 5, 1 };

            int inputMoney = Convert.ToInt32(Console.ReadLine());
            inputMoney = 1000 - inputMoney;
            int result = 0;

            foreach (var m in money)
            {
                // 나눈 몫을 저장
                result += inputMoney / m;
                inputMoney %= m; // 나누고 난 나머지를 저장해서 반복한다.

            }

            Console.WriteLine(result);
        }
    }
}
