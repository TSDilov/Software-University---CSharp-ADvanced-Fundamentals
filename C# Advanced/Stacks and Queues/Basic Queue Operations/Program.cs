using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersForStackCommands = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split()
                .Select(int.Parse));
            int numbersForDequeue = numbersForStackCommands[1];
            int numbersForSearch = numbersForStackCommands[2];

            for (int i = 0; i < numbersForDequeue; i++)
            {
                numbers.Dequeue();
            }
            if (numbers.Contains(numbersForSearch))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count <= 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"{numbers.Min()}");
            }
        }
    }
}
