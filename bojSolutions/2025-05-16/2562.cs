using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int max = 0; //최댓값
            int count = 0; //최댓값의 위치
            int[] num = new int[9];

            for(int i = 0; i < 9; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                if(max < num[i])
                {
                    max = num[i];
                    count = i + 1;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(count);
        }
    }
}
