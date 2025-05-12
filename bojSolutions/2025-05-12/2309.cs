using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int[] arr = new int[9];
            
            for(int i = 0; i < 9; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //합이 100이 되는 것을 찾아야 함, 완전탐색 || 총합 - 100 = X 해서 X가 나오는 합 2개를 빼기
            //2명을 제외한 조합을 전부 시도 (9C2)
            for(int i = 0; i < 9; i++)
            {
                for(int j = i + 1; j < 9; j++)
                {
                    int sum = 0;

                    // i, j를 제외한 7명 합 계산
                    for(int k = 0; k < 9; k++)
                    {
                        if(i != k && j != k)
                        {
                            sum += arr[k];
                        }
                    }

                    // 합이 100이면 정답
                    if (sum == 100)
                    {
                        //결과 배열 생성
                        int[] result = new int[7];
                        int count = 0;

                        for (int k = 0; k < 9; k++) 
                        {
                            if (k != i && k != j) 
                            {
                                result[count] = arr[k];
                                count++;
                            }
                        }

                        // 오름차순 정렬 (버블 정렬)
                        /*
                        for (int a = 0; a < result.Length - 1; a++)
                        {
                            for (int b = 0; b < result.Length - 1 - a; b++)
                            {
                                if (result[b] > result[b + 1])
                                {
                                    int temp = result[b];
                                    result[b] = result[b + 1];
                                    result[b + 1] = temp;
                                }
                            }
                        }
                        */
                        Array.Sort(result);

                        // 출력
                        for (int k = 0; k < 7; k++)
                        {
                            Console.WriteLine(result[k]);
                        }

                        return;
                    }
                }
            }
        }
    }
}
