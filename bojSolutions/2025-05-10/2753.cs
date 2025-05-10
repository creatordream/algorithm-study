using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string input = Console.ReadLine()!;
            
            int years = int.Parse(input);

            if(years % 4 == 0 && years % 100 != 0 || years % 400 == 0)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
        }
    }
}

