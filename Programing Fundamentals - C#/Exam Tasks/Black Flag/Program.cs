using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double allPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                allPlunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    allPlunder += (double)dailyPlunder / 2;
                }
                if (i % 5 == 0)
                {
                    allPlunder -= allPlunder * 0.3;
                }
            }
            if (allPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {allPlunder:F2} plunder gained.");
            }
            else
            {
                double percent = (allPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percent:F2}% of the plunder.");
            }

        }
    }
}
