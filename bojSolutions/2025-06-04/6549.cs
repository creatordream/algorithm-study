using System;
using System.Text;
using System.Collections.Generic;

namespace Boj
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while(true)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // 직사각형의 갯수와 높이가 연속해서 입력
                int rect = input[0]; // 직사각형 갯수

                if(rect == 0) // 0이면 종료
                    break;

                int[] height = new int[rect];
                Array.Copy(input, 1, height, 0, rect); // 직사각형의 갯수를 제외한 높이만 height 배열로 복사

                Stack<(int height, int index)> stack = new Stack<(int, int)>(); // 직사각형의 높이와 연속해서 위치했는지 확인을 위한 인덱스를 스택으로 선언
                long maxArea = 0; // 기징 큰 직사각형 넓이

                for (int i = 0; i < rect; i++) // 왼쪽부터 오른쪽까지 순서대로
                {
                    int startIndex = i; // 시작 인덱스 값을 i로 설정

                    while(stack.Count > 0 && stack.Peek().height > height[i]) // 스택에 값이 있고, 스택에 있는 막대가 현재 막대보다 높으면, 넓이 계산 후 pop
                    {
                        var (h, idx) = stack.Pop(); // 이전 막대 정보 꺼내기
                        long width = i - idx;       // 넓이는 현재 위치 - 이전 시작 위치(스택에 등록되어 있는 index 값)
                        long area = (long)h * width;
                        maxArea = Math.Max(maxArea, area); // 최대 넓이 갱신
                        startIndex = idx; // 높이가 낮은 막대의 시작 위치를 기억
                    }

                    stack.Push((height[i], startIndex));// 현재 막대를 스택에 push (연속 범위를 고려해 시작 인덱스는 갱신된 값 사용)
                }

                // for문이 끝까지 돌고 나서 스택에 남은 막대들이 있다면, 처리
                while (stack.Count > 0)
                {
                    var (h, idx) = stack.Pop();
                    long width = rect - idx;        // 전체 범위 끝까지 확장
                    long area = (long)h * width;
                    maxArea = Math.Max(maxArea, area); // 최대 넓이 갱신
                }

                if (rect != 0)
                    sb.AppendLine(maxArea.ToString());
            }
            Console.Write(sb);
        }
    }
}
