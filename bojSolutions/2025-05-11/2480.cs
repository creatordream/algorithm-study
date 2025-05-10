using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split();

            int f_num = int.Parse(input[0]);
            int s_num = int.Parse(input[1]);
            int t_num = int.Parse(input[2]);

            int price;

            if(f_num == s_num && s_num == t_num)
            {
                price = 10000 + f_num * 1000;
            }
            else if(f_num == s_num || f_num == t_num)
            {
                price = 1000 + f_num * 100;
            }
            else if(s_num == t_num)
            {
                price = 1000 + s_num * 100;
            }
            else
            {
                int max = f_num;
                
                if(max < s_num)
                {
                    max = s_num;
                }
                if(max < t_num)
                {
                    max = t_num;
                }
                price = max * 100;
            }

            Console.WriteLine(price);
        }
    }
}
