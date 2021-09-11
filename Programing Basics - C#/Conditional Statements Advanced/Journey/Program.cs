using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeVacation = "";
            double spendMoney = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    typeVacation = "Camp";
                    spendMoney = budget * 0.3;
                }
                else
                {
                    typeVacation = "Hotel";
                    spendMoney = budget * 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    typeVacation = "Camp";
                    spendMoney = budget * 0.4;
                }
                else
                {
                    typeVacation = "Hotel";
                    spendMoney = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                typeVacation = "Hotel";
                spendMoney = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeVacation} - {spendMoney:F2}");
        }
    }
}
