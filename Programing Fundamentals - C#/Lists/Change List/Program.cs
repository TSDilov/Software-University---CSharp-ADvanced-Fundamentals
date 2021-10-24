using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] input = command.Split();
                if (input[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
