using System;
using System.Linq;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            int left = 0, right = n - 1, count = 0;

            Array.Sort(a);

            while(left < right)
            {
                int sum = a[left] + a[right];
                if(sum == x)
                {
                    count++;
                    left++;
                    right--;
                }
                else if(sum < x)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            Console.WriteLine(count);
        }
    }
}
