using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string roomNum = Console.ReadLine();
            int[] cnt = new int[10];
            foreach (char c in roomNum)
                cnt[c - '0']++;
            int setCount = 0;
            int total = cnt[6] + cnt[9];
            int need = (total + 1) / 2;
            cnt[6] = need;
            cnt[9] = 0;


            for (int d = 0; d < 10; d++)
                setCount = Math.Max(setCount, cnt[d]);
            Console.WriteLine(setCount);
        }
    }
}
