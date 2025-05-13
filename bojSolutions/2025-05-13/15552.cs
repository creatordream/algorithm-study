using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int t = int.Parse(Console.ReadLine());
            int[] sum = new int[t];

            for(int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                sum[i] = a + b;
            }

            for(int i = 0; i < t; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
}
