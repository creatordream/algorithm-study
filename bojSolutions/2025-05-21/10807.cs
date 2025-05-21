using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int v = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] == v)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
