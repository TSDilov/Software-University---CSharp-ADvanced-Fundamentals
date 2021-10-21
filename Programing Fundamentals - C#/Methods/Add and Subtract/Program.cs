using System;

namespace AddandSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = MethodSubstractFromSum(MethodSum(firstNumber, secondNumber), thirdNumber);
            Console.WriteLine(result);
        }

        static int MethodSubstractFromSum(int sum, int thirdNumber)
        {
            return sum - thirdNumber;
        }

        static int MethodSum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
