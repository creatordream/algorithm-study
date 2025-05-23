using System;
using System.Text;

namespace 백준
{    
    class HelloWorld {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            LinkedList<char> list = new LinkedList<char>(input);
            list.AddLast(' ');
            LinkedListNode<char> cursor = list.Last;

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] control = Console.ReadLine().Split();

                switch(control[0])
                {
                    case "L" :
                        if (cursor.Previous != null)
                            cursor = cursor.Previous;
                        break;
                    case "D" :
                        if (cursor.Next != null)
                            cursor = cursor.Next;
                        break;
                    case "B" :
                        if (cursor.Previous != null)
                            list.Remove(cursor.Previous);
                        break;
                    case "P" :
                        list.AddBefore(cursor, char.Parse(control[1]));
                        break;
                }
            }
            list.RemoveLast();
            StringBuilder result = new StringBuilder();

            foreach(char c in list)
            {
                result.Append(c);
            }

            Console.WriteLine(result);
        }
    }
}
