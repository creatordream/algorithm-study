using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 2 * n - 1; i++)
            {
                int level; //층 수
                int space; //공백
                int stars; //별
                if(i <= n)
                {
                    level = i;
                }
                else
                {
                    level = 2 * n - i;
                }

                space = level - 1;
                stars = 2 * (n - level) + 1;

                for(int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                
                for(int k = 0; k < stars; k++)
                {
                    Console.Write("*");
                }

                for(int l = 0; l < space; l++)
                {
                    Console.Write(" ");
                }

                Console.Write("\n");
            }
        }
    }
}
