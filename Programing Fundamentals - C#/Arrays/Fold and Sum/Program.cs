using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = inputArray.Length / 4;
            int[] firstNumbers = new int[length];
            int[] array = new int[length * 2];
            int[] sumArray = new int[array.Length];

            for (int i = 0; i < length; i++)
            {
                firstNumbers[i] = inputArray[i];
            }
            Array.Reverse(firstNumbers);
            for (int i = 0; i < length; i++)
            {
                array[i] = firstNumbers[i];
            }
            for (int j = 0; j < array.Length / 2; j++)
            {
                array[array.Length / 2 + j] = inputArray[inputArray.Length - 1 - j];
            }
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k <= length + array.Length; k++)
                {
                    if (k == length + array.Length)
                    {
                        break;
                    }
                    inputArray[k] = inputArray[k + 1];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                sumArray[i] = array[i] + inputArray[i];
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
