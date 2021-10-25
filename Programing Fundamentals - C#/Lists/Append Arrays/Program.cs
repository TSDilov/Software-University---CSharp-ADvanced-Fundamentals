using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> entryList = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> endList = new List<int>();
            for (int i = entryList.Count - 1; i >= 0; i--)
            {
                int[] numbers = entryList[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                foreach (var number in numbers)
                {
                    endList.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", endList));
        }
    }
}
