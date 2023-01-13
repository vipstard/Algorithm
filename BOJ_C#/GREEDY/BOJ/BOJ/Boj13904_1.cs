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
                String[] strArr = Console.ReadLine().Split(' ');
                works[i] = new Homework(Convert.ToInt32(strArr[0]), Convert.ToInt32(strArr[1]));
            }

            works = works.OrderByDescending(i => i.deadline).ToArray();
            int idx = 0, result = 0;
            
            // 우선순위 큐 사용
            PriorityQueue<Homework, int> queue = new PriorityQueue<Homework, int>();

            for (int i = 100; i >= 1; i--)
            {
                while (idx < n  && works[idx].deadline >=i)
                {
                    queue.Enqueue(works[idx], -works[idx++].score);
                }

                if (queue.Count > 0)
                    result += queue.Dequeue().score;
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
