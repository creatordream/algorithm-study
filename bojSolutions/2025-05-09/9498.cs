using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            int score = int.Parse(input);

            if(score <= 100 && score >= 90)
            {
                Console.WriteLine("A");
            }
            else if(score < 90 && score >= 80)
            {
                Console.WriteLine("B");
            }
            else if(score < 80 && score >= 70)
            {
                Console.WriteLine("C");
            }
            else if(score < 70 && score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
