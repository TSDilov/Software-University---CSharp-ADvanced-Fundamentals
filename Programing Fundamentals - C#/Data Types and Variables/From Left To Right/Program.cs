using System;
using System.Numerics;

namespace FromLefttoTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                string[] input = Console.ReadLine().Split();
                BigInteger[] numbers = { BigInteger.Parse(input[0]), BigInteger.Parse(input[1]) };

                Array.Sort(numbers);
                numbers[1] = BigInteger.Abs(numbers[1]);
                input[1] = numbers[1].ToString();

                BigInteger sum = 0;
                foreach (var digit in input[1])
                {
                    sum += (BigInteger)char.GetNumericValue(digit);
                }
                Console.WriteLine(sum);

            }
        }
    }
}
