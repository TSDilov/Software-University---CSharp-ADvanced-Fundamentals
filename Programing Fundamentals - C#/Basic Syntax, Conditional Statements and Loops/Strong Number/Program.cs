using System;

namespace Strongnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int firstNum = num;
            int sum = 0;
            while (num > 0)
            {
                int currentNum = num % 10;
                int factoriel = 1;
                for (int i = 1; i <= currentNum; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                num /= 10;
            }
            if (sum == firstNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
