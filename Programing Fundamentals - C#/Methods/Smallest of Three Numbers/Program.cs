using System;

namespace SmallestofThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int minNumber = MethodForMinNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(minNumber);
        }

        static int MethodForMinNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int minNumber = firstNumber;
            if (secondNumber < firstNumber)
            {
                minNumber = secondNumber;
            }
            if (thirdNumber < minNumber)
            {
                minNumber = thirdNumber;
            }
            return minNumber;
        }
    }
}
