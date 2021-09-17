using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = Console.ReadLine();
            int num;
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (stop != "stop")
            {
                num = int.Parse(stop);
                bool nonPrime = false;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");                  
                }
                else
                {
                    if (num == 0 || num == 1)
                    {
                        nonPrime = true;
                        nonPrimeSum += num;
                    }
                    else
                    {
                        for (int i = 2; i < num; i++)
                        {
                            if (num % i == 0)
                            {
                                nonPrime = true;
                                nonPrimeSum += num;
                                break;
                            }
                        }
                        if (!nonPrime)
                        {
                            primeSum += num;
                        }
                    }
                }

                stop = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
