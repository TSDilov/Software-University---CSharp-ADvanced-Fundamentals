using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int customers = int.Parse(Console.ReadLine());

            int hours = 0;

            while (customers > 0)
            {
                customers -= firstEmployee + secondEmployee + thirdEmployee;
                hours++;
                if (hours % 4 == 0 && hours >= 4)
                {
                    hours++;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
