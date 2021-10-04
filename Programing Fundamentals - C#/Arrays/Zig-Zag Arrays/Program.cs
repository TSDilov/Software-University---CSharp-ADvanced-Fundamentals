using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfInt = int.Parse(Console.ReadLine());
            int[] arr1 = new int[numOfInt];
            int[] arr2 = new int[numOfInt];
            
            for (int i = 0; i < numOfInt; i++)
            {
                int[] integers = Console.ReadLine().Split().
                    Select(int.Parse).ToArray();
                int firstNumber = integers[0];
                int secondNumber = integers[1];
                if (i % 2 == 0)
                {
                    arr1[i] = firstNumber;
                    arr2[i] = secondNumber;
                }
                else
                {
                    arr1[i] = secondNumber;
                    arr2[i] = firstNumber;
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
