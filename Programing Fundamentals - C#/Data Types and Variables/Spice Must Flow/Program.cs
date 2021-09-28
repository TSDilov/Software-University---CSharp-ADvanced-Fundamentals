using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int halfN = n / 2;
            int targetsPoked = 0;
            while (n >= m)
            {
                targetsPoked++;
                n -= m;
                if (halfN == n && y > 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targetsPoked);
        }
    }
}
