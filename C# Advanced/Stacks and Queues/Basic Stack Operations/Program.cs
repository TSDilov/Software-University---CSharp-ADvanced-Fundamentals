using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersForStackCommands = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int[] numbersToAdd = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            var numbers = new Stack<int>();
            int numbersForPush = numbersForStackCommands[0];
            int numbersForPop = numbersForStackCommands[1];
            int numbersForSearch = numbersForStackCommands[2];

            for (int i = 0; i < numbersForPush; i++)
            {
                numbers.Push(numbersToAdd[i]);
            }
            for (int i = 0; i < numbersForPop; i++)
            {
                numbers.Pop();
            }
            if (numbers.Contains(numbersForSearch))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int minNumber = int.MaxValue;
                for (int i = 0; i < numbers.Count; i++)
                {
                    int popedNumber = numbers.Pop();
                    if (popedNumber < minNumber)
                    {
                        minNumber = popedNumber;
                    }
                }
                Console.WriteLine(minNumber);
            }
        }
    }
}
