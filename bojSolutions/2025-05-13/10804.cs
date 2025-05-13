using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int[] card = new int[20];
            for(int i = 0; i < 20; i++)
                card[i] = i + 1;
            int temp;

            for(int i = 0; i < 10; i++)
            {
                string[] input = Console.ReadLine().Split();
                
                int a = int.Parse(input[0]) - 1;
                int b = int.Parse(input[1]) - 1;

                while (a < b)
                {
                    temp = card[a];
                    card[a] = card[b];
                    card[b] = temp;
                    a++;
                    b--;
                }
            }

            Console.WriteLine(string.Join(" ", card));
        }
    }
}
