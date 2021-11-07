using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            int reminder = 0;

            StringBuilder multiply = new StringBuilder();
            if (firstNumber == "0" || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(firstNumber[i].ToString());
                int product = currentDigit * secondNumber + reminder;
                int result = product % 10;
                reminder = product / 10;
                multiply.Insert(0, result);
            }
            if (reminder > 0)
            {
                multiply.Insert(0, reminder);
            }
            Console.WriteLine(multiply);
        }
    }
}
