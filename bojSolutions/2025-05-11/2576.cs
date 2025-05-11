using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int sum = 0;
            int min = int.MaxValue;
            int[] num = new int[7];
            
            for(int i = 0; i < 7; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < 7; i++)
            {
                if(num[i] % 2 == 1)
                {
                    sum += num[i];
                }
            }

            for(int i = 0; i < 7; i++)
            {
                if(num[i] % 2 == 1)
                {
                    if(min > num[i])
                        min = num[i];
                }
            }

            if(sum == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }
    }
}
