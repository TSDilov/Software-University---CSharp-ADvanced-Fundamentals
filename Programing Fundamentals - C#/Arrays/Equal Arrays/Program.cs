using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    sum = 0;
                    break;
                }
                else
                {
                    sum += arr1[i];
                }
            }
            if (sum > 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
