using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                if (MethodSumDevideByEight(i) && MethodAtLeastOneOddDIgit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool MethodAtLeastOneOddDIgit(int number)
        {
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        static bool MethodSumDevideByEight(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            bool isDevisibleByEight = sum % 8 == 0;
            return isDevisibleByEight;
        }
    }
}
