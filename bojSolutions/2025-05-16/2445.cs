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
                int leftStars; //왼쪽 별
                int rightStars; //오른쪽 별
                if(i <= n)
                {
                    level = i;
                }
                else
                {
                    level = 2 * n - i;
                }

                space = 2 * (n - level);
                leftStars = rightStars = level;

                for(int j = 0; j < leftStars; j++)
                {
                    Console.Write("*");
                }
                
                for(int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }

                for(int l = 0; l < rightStars; l++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}
