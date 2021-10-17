using System;

namespace SignofIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            MethodwithNumbers(inputNumber);
        }
        static void MethodwithNumbers(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0 )
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
