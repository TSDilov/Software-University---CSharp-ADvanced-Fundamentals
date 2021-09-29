using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= lastNumber; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                string boolean = isPrime.ToString().ToLower();
                Console.WriteLine($"{i} -> {boolean}");
            }
        }
    }
}
