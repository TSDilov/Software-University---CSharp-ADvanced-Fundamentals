using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            arrayFibonacci = new int[n + 1];
            GetFibonacci(n);

            Console.WriteLine(arrayFibonacci[n]);

        }
        private static int[] arrayFibonacci = null;
        static int GetFibonacci(int index)
        {
            if (arrayFibonacci[index] != 0)
            {
                return arrayFibonacci[index];
            }
            if (index <= 2)
            {
                arrayFibonacci[index] = 1;
                return arrayFibonacci[index];
            }
            arrayFibonacci[index] = GetFibonacci(index - 1) + GetFibonacci(index - 2);

            return arrayFibonacci[index];
        }
    }
}
