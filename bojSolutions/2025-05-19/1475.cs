using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string roomNum = Console.ReadLine();
            int[] cnt = new int[10];
            
            for (int i = 0; i < roomNum.Length; i++)
            {
                char c = roomNum[i];
                cnt[c - '0']++;
            }

            // 6/9는 뒤집어 쓸 수 있으므로 합쳐서 올림 나누기
            int total = cnt[6] + cnt[9];
            cnt[6] = (total + 1) / 2;
            cnt[9] = 0;

            // 가장 많이 필요한 숫자 개수가 세트 수
            int setCount = 0;
            for (int d = 0; d < 10; d++)
                setCount = Math.Max(setCount, cnt[d]);

            Console.WriteLine(setCount);
        }
    }
}
