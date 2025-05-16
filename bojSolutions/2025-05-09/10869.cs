
using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");

            int A = int.Parse(numbers[0]);
            int B = int.Parse(numbers[1]);

            Console.WriteLine("{0}", A + B);
            Console.WriteLine("{0}", A - B);
            Console.WriteLine("{0}", A * B);
            Console.WriteLine("{0}", A / B);
            Console.WriteLine("{0}", A % B);
        }
    }
}
