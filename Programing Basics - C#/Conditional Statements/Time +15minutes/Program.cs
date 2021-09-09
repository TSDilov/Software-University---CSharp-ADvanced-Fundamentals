using System;

namespace Time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int minAll = hour * 60 + min;
            int minResult = minAll + 15;
            int hourResult = minResult / 60;
            int minResult1 = minResult % 60;
            if (minResult1 < 10)
            {
                if (hourResult == 24)
                {
                    Console.WriteLine($"{0}:0{minResult1}");
                }
                else
                {
                    Console.WriteLine($"{hourResult}:0{minResult1}");
                }
            }
            else
            {
                if (hourResult == 24)
                {
                    Console.WriteLine($"{0}:{minResult1}");
                }
                else
                {
                    Console.WriteLine($"{hourResult}:{minResult1}");
                }
            }
        }
    }
}
