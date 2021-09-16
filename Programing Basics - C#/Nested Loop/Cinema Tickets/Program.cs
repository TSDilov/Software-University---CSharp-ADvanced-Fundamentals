using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int ticketCount = 0;
            int students = 0;
            int standard = 0;
            int kid = 0;
            int ticketsForMovie = 0;
            while (movie != "Finish")
            {
                int maxCustomers = int.Parse(Console.ReadLine());
                for (int i = 0; i < maxCustomers; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    ticketsForMovie++;
                    ticketCount++;
                    if (ticketType == "student" )
                    {
                        students++;
                    }
                    else if (ticketType == "kid")
                    {
                        kid++;
                    }
                    else
                    {
                        standard++;
                    }
                }
                Console.WriteLine($"{movie} - {(double)(ticketsForMovie/(double)maxCustomers) * 100:F2}% full.");
                ticketsForMovie = 0;
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {ticketCount}");
            Console.WriteLine($"{(double)(students / (double)ticketCount) * 100:F2}% student tickets.");
            Console.WriteLine($"{(double)(standard / (double)ticketCount) * 100:F2}% standard tickets.");
            Console.WriteLine($"{(double)(kid / (double)ticketCount) * 100:F2}% kids tickets. ");
        }
    }
}
