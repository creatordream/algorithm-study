using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int[] counts = new int[10];
            int sum = 0;
            
            sum = A * B * C;
            string s = sum.ToString();

            for (int i = 0; i < s.Length; i++)
            {
            	char c = s[i];
                counts[c - '0']++;
            }

            for (int i = 0; i < 10; i++) {
                Console.Write(counts[i]);
                if (i < 9)
                    Console.Write(' ');
            }
        }
    }
}
