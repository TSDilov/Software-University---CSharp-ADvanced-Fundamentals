using System;

namespace Mathoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char operatorr = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = CalculateMethod(firstNumber, operatorr, secondNumber);
            Console.WriteLine(result);
        }

        static double CalculateMethod(double firstNumber, char operatorr, double secondNumber)
        {
            double result = 0;
            if (operatorr == '+')
            {
                result = firstNumber + secondNumber;
            }
            else if (operatorr == '-')
            {
                result = firstNumber - secondNumber;
            }
            else if (operatorr == '*')
            {
                result = firstNumber * secondNumber;
            }
            else if (operatorr == '/')
            {
                result = firstNumber / secondNumber;
            }
            return result;
        }
    }
}
