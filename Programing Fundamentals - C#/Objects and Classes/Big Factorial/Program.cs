using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger faktorial = 1;
            for (int i = 2; i <= n; i++)
            {
                faktorial *= i;
            }
            Console.WriteLine(faktorial);
        }
    }
}
