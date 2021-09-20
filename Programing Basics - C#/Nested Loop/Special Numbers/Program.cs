using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int h = 1; h <= 9; h++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            if (num % i == 0 && num % k == 00 && num % j == 0 && num % h == 0)
                            {
                                Console.Write($"{h}{j}{k}{i} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
