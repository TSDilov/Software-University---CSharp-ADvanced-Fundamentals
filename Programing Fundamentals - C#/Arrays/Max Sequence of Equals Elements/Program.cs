using System;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int maxCounter = 0;
            int biggestSequenceValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length - 1 && numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else if (i < numbers.Length - 1 && numbers[i] != numbers[i + 1])
                {
                    counter++;
                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                        biggestSequenceValue = numbers[i];
                    }
                    counter = 0;
                }
                else if (numbers[i] == numbers[numbers.Length - 1])
                {
                    counter++;
                    if (maxCounter< counter)
                    {
                        maxCounter = counter;
                        biggestSequenceValue = numbers[i];
                    }
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(biggestSequenceValue + " ");
            }
        }
    }
}
