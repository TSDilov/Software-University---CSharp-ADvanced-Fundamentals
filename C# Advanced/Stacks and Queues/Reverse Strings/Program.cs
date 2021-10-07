using System;
using System.Collections.Generic;

namespace ReverseStringsWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> forReverse = new Stack<char>();

            foreach (var ch in input)
            {
                forReverse.Push(ch);
            }
            while (forReverse.Count > 0)
            {
                Console.Write(forReverse.Pop());
            }
        }
    }
}
