using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split();
            
            int N = int.Parse(input[0]);
            int X = int.Parse(input[1]);

            string[] numbers = Console.ReadLine().Split();
            for(int i = 0; i < N; i++)
            {
                int A = int.Parse(numbers[i]);
                if(A < X)
                {
                    Console.Write(A + " ");
                }
            }
        }
    }
}
