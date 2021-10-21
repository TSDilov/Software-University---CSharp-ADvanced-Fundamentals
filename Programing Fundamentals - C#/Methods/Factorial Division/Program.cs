using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double result = MethodFaktorialFirstNumber(firstNumber) / MethodFaktorialSecondNumber(secondNumber);
            Console.WriteLine($"{result:F2}");
        }

        static double MethodFaktorialSecondNumber(int secondNumber)
        {
            double faktorial = 1;
            for (int j = 1; j <= secondNumber ; j++)
            {
                faktorial *= j;
            }
            return faktorial;
        }

        static double MethodFaktorialFirstNumber(int firstNumber)
        {
            double faktorial = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                faktorial *= i;
            }
            return faktorial;
        }
    }
}
