using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] operation = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (operation[0] == 1)
                {
                    numbers.Push(operation[1]);
                }
                else if (operation[0] == 2 && numbers.Count > 0)
                {
                    numbers.Pop();
                }
                else if (operation[0] == 3 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (operation[0] == 4 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
