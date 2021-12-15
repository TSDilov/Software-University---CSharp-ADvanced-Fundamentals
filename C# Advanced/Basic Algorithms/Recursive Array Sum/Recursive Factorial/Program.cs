using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = GetFactorial(n);
            Console.WriteLine(factorial);
        }

        private static int GetFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * GetFactorial(n - 1);
        }
    }
}
