using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (operation == "add")
            {
                AddMethod(firstNumber, secondNumber);
            }
            else if (operation == "subtract")
            {
                SubtractMethod(firstNumber, secondNumber);
            }
            else if (operation == "multiply")
            {
                MultiplyMethod(firstNumber, secondNumber);
            }
            else
            {
                DevideMethod(firstNumber, secondNumber);
            }
                
        }

        static void DevideMethod(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            Console.WriteLine($"{result}");
        }

        static void MultiplyMethod(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            Console.WriteLine($"{result}");
        }

        static void SubtractMethod(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            Console.WriteLine($"{result}");
        }

        static void AddMethod(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine($"{result}");
        }
    }
}
