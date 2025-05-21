using System;
using System.Text;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < n; i++)
            {
                string[] test = Console.ReadLine().Split();
                string case1 = test[0];
                string case2 = test[1];

                char[] case1Arr = case1.ToCharArray();
                char[] case2Arr = case2.ToCharArray();
                Array.Sort(case1Arr);
                Array.Sort(case2Arr);

                sb.AppendLine(new string(case1Arr) == new string(case2Arr) ? "Possible" : "Impossible");
            }

            Console.Write(sb.ToString());
        }
    }
}
