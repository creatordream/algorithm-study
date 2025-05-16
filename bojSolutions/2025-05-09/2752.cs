using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split();

            int[] numbers = Array.ConvertAll(input, int.Parse);

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                for(int j = 0; j < numbers.Length -i - 1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
