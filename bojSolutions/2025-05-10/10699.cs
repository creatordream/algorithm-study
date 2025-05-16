using System;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            DateTime seoulTime = DateTime.Now + TimeSpan.FromHours(9);
            Console.WriteLine(seoulTime.ToString("yyyy-MM-dd"));
        }
    }
}
