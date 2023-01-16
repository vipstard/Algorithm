using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj1931
    {
        static void Main(String[] args)
        {
            int n =Convert.ToInt32(Console.ReadLine());
            List<Conference> conferences = new List<Conference>();
            int result = 0;
            int minStartTime = 0; // 시작시간

            for (int i = 0; i < n; i++)
            {
                String[] inputTime = Console.ReadLine().Split();
                conferences.Add(new Conference(Convert.ToInt32(inputTime[0]), Convert.ToInt32(inputTime[1])));
            }

            // 끝나는 시간을 먼저 오름차순 정렬하고 이후 시작시간을 오름차순 정렬 한다.
            conferences = conferences.OrderBy(x => x.endTime).ThenBy(y => y.startTime).ToList();

            for (int i = 0; i < n; i++)
            {
                // 이전 회의가 끝난 후 다음 회의 시작시간이 같거나 크면  다다음 회의 시작시간 변경하고 1씩 추가
                if (minStartTime <= conferences[i].startTime)
                {
                    minStartTime = conferences[i].endTime;
                    result++;
                }
            }

            Console.WriteLine(result);
        }

        public class Conference {

            public int  startTime { get; set; }
            public int  endTime { get; set; }

            public Conference(int startTime, int endTime)
            {
                this.startTime = startTime;
                this.endTime = endTime;
            }
        }
    }
}
