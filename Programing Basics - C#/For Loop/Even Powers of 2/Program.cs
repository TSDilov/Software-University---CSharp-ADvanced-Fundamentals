using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 ==0)
                {
                    num *= 2 * 2;
                    Console.WriteLine(num);
                }
            }
        }
    }
}
