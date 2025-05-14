using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }

                for(int j = 2 * n - 1; j >= 2 * i - 1; j--)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}
