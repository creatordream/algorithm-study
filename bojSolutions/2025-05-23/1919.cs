using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            int deleteWord = 0;
            int[] cnt1 = new int[26];
            int[] cnt2 = new int[26];
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            foreach (char c in input1) cnt1[c - 'a']++;
            foreach (char c in input2) cnt2[c - 'a']++;

            for(int i = 0; i < 26; i++)
            {
                deleteWord += Math.Abs(cnt1[i] - cnt2[i]);
            }

            Console.Write(deleteWord);
        }
    }
}
