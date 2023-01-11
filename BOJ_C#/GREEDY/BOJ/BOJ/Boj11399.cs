namespace BOJ
{
    public class Boj11399
    {
        static void Main(string[] args)
        {
            // 입력받기
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();

            // 입력받은 배열 int형 배열로 내림차순 변환후 정렬한다.
            int[] intArray = arr.Select(int.Parse).ToArray();
            Array.Sort(intArray);

            int sum = 0;


            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    sum += intArray[j];
                }
            }

            Console.WriteLine(sum);


        }
    }
}