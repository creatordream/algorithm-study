using System;
using System.Text;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split();

            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);

            long min = Math.Min(a, b);
            long max = Math.Max(a, b);

            long between = max - min - 1;

            if (between <= 0) {
                Console.WriteLine(0);
                return;
            }

            Console.WriteLine(between);

            StringBuilder sb = new StringBuilder();

            for (long i = min + 1; i < max; i++) {
                sb.Append(i);
                if (i < max - 1)
                    sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
