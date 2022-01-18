using System;

namespace Operations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();
            var thirdNumber = Console.ReadLine();

            var mathOperation = new MathOperations();
            Console.WriteLine(mathOperation.Add(int.Parse(firstNumber), int.Parse(secondNumber)));
            Console.WriteLine(mathOperation.Add(double.Parse(firstNumber), double.Parse(secondNumber), double.Parse(thirdNumber)));
            Console.WriteLine(mathOperation.Add(decimal.Parse(firstNumber), decimal.Parse(secondNumber), decimal.Parse(thirdNumber)));
        }
    }
}
