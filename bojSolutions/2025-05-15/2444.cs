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

                space = n - level;
                stars = 2 * level - 1;

                //상
                for(int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }

                for(int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}
