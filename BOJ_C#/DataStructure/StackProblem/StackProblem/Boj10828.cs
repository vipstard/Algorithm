using System.Text;

namespace StackProblem
{
    public class Stack
    {
        private int top = -1;
        private  int[] _intArr;
        public string command { get; set; }
        public int num { get; set; }
        public int cnt = 0;
       

        public Stack(){ }

        // 스택
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = Convert.ToInt32(Console.ReadLine());
         String[] strArr;
         List<Stack> list = new List<Stack>();
         Stack temp = new Stack();

             for (int i = 0; i < n; i++)
             {
                 strArr = Console.ReadLine().Split();
                 temp.command = strArr[0];

                 if (strArr[0].Equals("push"))
                 {
                     temp.num = Convert.ToInt32(strArr[1]);
                     temp.Push(temp.num);
                 }
                 else if (strArr[0].Equals("top")) sb.Append(temp.Top() + "\n");
                 else if (strArr[0].Equals("size")) sb.Append(temp.Size() + "\n");
                 else if (strArr[0].Equals("empty")) sb.Append(temp.IsEmpty() ? "1" + "\n" : "0" + "\n");
                 else if (strArr[0].Equals("pop")) sb.Append(temp.Pop() + "\n");
             }

             Console.WriteLine(sb);
        }

        public  void Push(int data)
        {
            Array.Resize(ref _intArr, ++cnt);
            if (IsFull()) throw new Exception();
            this._intArr[++top] = data;
        }

        public bool IsFull()
        {
            return top == this._intArr.Length - 1;
        }

        public int Pop()
        {
            int returnData = -1;
            if (IsEmpty())return -1;
            else
            {
                returnData = this._intArr[top];
                _intArr[top] = 0;
                top--;
            }

            return returnData;
        }

        public int Top()
        {
            int returnData = -1;
            if (!IsEmpty()) returnData = this._intArr[top];

            return returnData;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public int Size()
        {
            return top + 1;
        }
    }
}