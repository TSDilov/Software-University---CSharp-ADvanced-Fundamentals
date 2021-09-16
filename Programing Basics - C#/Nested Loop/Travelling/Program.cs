using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double budget = 0.0;
            double save = 0.0;
            while (destination != "End")
            {
                budget = double.Parse(Console.ReadLine());
                while (save< budget)
                {
                    save += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                save = 0.0;
                destination = Console.ReadLine();
            }
        }
    }
}
