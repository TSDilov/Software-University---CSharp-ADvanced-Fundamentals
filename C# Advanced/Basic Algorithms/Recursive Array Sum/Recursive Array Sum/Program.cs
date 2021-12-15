using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = SumOfArray(numbers, 0);
            Console.WriteLine(sum);
        }

        private static int SumOfArray(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                return 0;
            }
            return numbers[index] + SumOfArray(numbers, index + 1);
        }
    }
}
