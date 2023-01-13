using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ
{
    public class Boj13904
    {
        static void Main(String[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            Homework[] works = new Homework[n];

            for (int i = 0; i < n; i++)
            {
                String[] strArr = Console.ReadLine().Split();
                works[i] = new Homework(Convert.ToInt32(strArr[0]), Convert.ToInt32(strArr[1]));
            }

            works = works.OrderByDescending(i => i.deadline).ToArray();
            int idx = 0, result = 0;
            
            // 우선순위 큐 : 큐에서 우선 순위가 가장 낮은 항목이 제거된다.
            PriorityQueue<Homework, int> queue = new PriorityQueue<Homework, int>();

            for (int i = 100; i > 0; i--)
            {
                // 인덱스가 개수 n 을넘어가지 않으면서 데드라인이 i일보다 큰 데드라인만 큐에 넣는다.
                while (idx<n && works[idx].deadline>=i)
                {
                    // 큐에 집어넣고 배열의 인덱스를 증가시킨다.
                    queue.Enqueue(works[idx], -works[idx++].score); 
                }

                // 우선순위 큐에 담긴 갯수가 1개라도 있으면 결과값에 누적합을 한다.
                if (queue.Count > 0)
                {
                    result += queue.Dequeue().score; // 우선순위가 낮은 항목부터 나옴
                }
            }

            Console.WriteLine(result);

        }
    }

    public class Homework
    {
        public int  deadline { get; set; }
        public int  score { get; set; }

        public Homework()
        {
        }

        public Homework(int deadline, int score)
        {
            this.deadline = deadline;
            this.score = score;
        }
    }
}
