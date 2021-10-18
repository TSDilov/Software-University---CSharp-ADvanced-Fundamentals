using System;

namespace MultiplyEvensbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);

            int evenSum = EvenSumMethod(input);
            int oddSum = OddSumMethod(input);
            Console.WriteLine(MultiplyMetho(evenSum, oddSum));
        }

        static int MultiplyMetho(int evenSum, int oddSum)
        {
            int result = evenSum * oddSum;
            return result;
        }

        static int OddSumMethod(int input)
        {
            string inputArray = input.ToString();
            int sumOdd = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                char digit = inputArray[i];
                int numberFromInputArray = (int)char.GetNumericValue(digit);
                if (numberFromInputArray % 2 != 0)
                {
                    sumOdd += numberFromInputArray;
                }
            }
            return sumOdd;
        }

        static int EvenSumMethod(int input)
        {
            string inputArray = input.ToString();
            int sumEven = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                char digit = inputArray[i];
                int numberFromInputArray = (int)char.GetNumericValue(digit);
                if (numberFromInputArray % 2 == 0)
                {
                    sumEven += numberFromInputArray;
                }
            }
            return sumEven;
        }
    }
}
