using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int[,] array = new int[3, 4];

            for(int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split();
                for(int j = 0; j < 4; j++)
                {
                    array[i, j] = int.Parse(input[j]);
                }

            }

            for(int i = 0; i < 3; i++)
            {
                int count = 0;

                for(int j = 0; j < 4; j++)
                {
                    if(array[i, j] == 0)
                        count++;
                }

                switch(count)
                {
                    case 0 :
                        Console.WriteLine("E"); //윷
                        break;
                    case 1 :
                        Console.WriteLine("A");
                        break;
                    case 2 :
                        Console.WriteLine("B");
                        break;
                    case 3 :
                        Console.WriteLine("C");
                        break;
                    case 4 :
                        Console.WriteLine("D");
                        break;
                }
            }
        }
    }
}
