using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            double p4 = 0.00;
            double p5 = 0.00;
            for (int i = 1; i <=n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num<200)
                {
                    p1 += 1;
                }
                else if ( num< 400)
                {
                    p2 += 1;
                }
                else if (num<600)
                {
                    p3 += 1;
                }
                else if (num<800)
                {
                    p4 += 1;
                }
                else
                {
                    p5 += 1;
                }
            }
            Console.WriteLine($"{p1 / n * 100:F2}"+"%");
            Console.WriteLine($"{p2 / n * 100:F2}"+"%");
            Console.WriteLine($"{p3 / n * 100:F2}"+"%");
            Console.WriteLine($"{p4 / n * 100:F2}"+"%");
            Console.WriteLine($"{p5 / n * 100:F2}"+"%");
        }
    }
}
