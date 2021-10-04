using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfRotations % arrayOfIntegers.Length; i++)
            {
                int firstNumber = arrayOfIntegers[0];
                for (int j = 0; j < arrayOfIntegers.Length - 1; j++)
                {
                    arrayOfIntegers[j] = arrayOfIntegers[j + 1];
                }
                arrayOfIntegers[arrayOfIntegers.Length - 1] = firstNumber;
            }
            Console.WriteLine(String.Join(" ", arrayOfIntegers));
        }
    }
}
