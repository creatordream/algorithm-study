using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string input = Console.ReadLine();
	    int[] counts = new int[26];
			
	    for (int i = 0; i < input.Length; i++)
	    {
	        char c = input[i];
		if (c >= 'a' && c <= 'z')
		{
		    counts[c - 'a']++;
		}
	    }

            for (int i = 0; i < 26; i++) {
                Console.Write(counts[i]);
                if (i < 25)
                    Console.Write(' ');
            }
        }
    }
}
