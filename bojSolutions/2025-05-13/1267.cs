using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] time = new int[n];
            float ypay = 0, mpay = 0;

            string[] input = Console.ReadLine().Split();

            for(int i = 0; i < n; i++)
            {
                time[i] = int.Parse(input[i]);

                ypay += (time[i] / 30 + 1) * 10;
                mpay += (time[i] / 60 + 1) * 15;
            }

            if(ypay == mpay)
            {
                Console.WriteLine("Y M {0}", ypay);
            }
            else if(ypay > mpay)
            {
                Console.WriteLine("M {0}", mpay);
            }
            else
            {
                Console.WriteLine("Y {0}", ypay);
            }
        }
    }
}
