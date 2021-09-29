using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal floatOne = decimal.Parse(Console.ReadLine());
            decimal floatTwo = decimal.Parse(Console.ReadLine());

            decimal eps = 0.000001M;
            decimal difference = Math.Abs(floatOne - floatTwo);

            if (difference < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
