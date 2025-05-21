using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string[] nk = Console.ReadLine().Split();
            int n = int.Parse(nk[0]); // 인원
            int k = int.Parse(nk[1]); // 최대 방 인원

            int[,] roomNum = new int[2, 7]; // [성별, 학년]

            int roomCnt = 0;

            for(int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int se = input[0]; // 성별
                int grade = input[1]; // 학년

                roomNum[se, grade]++; //방에 인원 배치
            }

            for(int i = 0; i < 2; i++) // 성별
            {
                for(int j = 1; j <= 6; j++) // 학년
                {
                    roomCnt += roomNum[i, j] / k;   // 한 방에 cut명씩 넣을 때 필요한 최소 방 수 몫만큼
                    if (roomNum[i, j] % k != 0)           // 나머지(남는 인원)가 있으면
                        roomCnt++;                    // 방 하나를 더 써야 함
                }
            }

            Console.WriteLine(roomCnt);
        }
    }
}
