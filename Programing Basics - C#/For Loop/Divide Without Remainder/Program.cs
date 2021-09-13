using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            for (int i = 1; i <=n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    p1 += 1;
                }
                if (num%3==0)
                {
                    p2 += 1;
                }
                if (num%4==0)
                {
                    p3 += 1;
                }
            }
            Console.WriteLine($"{p1 / n * 100:F2}"+"%");
            Console.WriteLine($"{p2 / n * 100:F2}"+"%");
            Console.WriteLine($"{p3 / n * 100:F2}"+"%");
        }
    }
}
