using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double rent = 0.0;           
            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else
            {
                rent = 2600; 
            }
            if (num <= 6)
            {
                rent = rent - rent * 0.1;
            }
            else if (num >= 7 && num<=11)
            {
                rent = rent - rent * 0.15;
            }
            else
            {
                rent = rent - rent * 0.25;
            }
            if (num % 2 == 0 && season != "Autumn" )
            {
                rent = rent - rent * 0.05;
            }
            double residue = budget - rent;
            if (residue >= 0)
            {                
                Console.WriteLine($"Yes! You have {residue:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(residue):F2} leva.");
            }
        }
    }
}
