using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int[] num = new int[5];
            int sum = 0, average;
            
            for(int i = 0; i < 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                sum += num[i];
            }

            Array.Sort(num);
            int center = num[2];

            average = sum / 5;

            Console.WriteLine(average);
            Console.WriteLine(center);
        }
    }
}
