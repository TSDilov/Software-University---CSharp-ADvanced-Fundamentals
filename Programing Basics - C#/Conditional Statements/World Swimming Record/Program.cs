using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordinSec = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double SecForM = double.Parse(Console.ReadLine());
            double distance15 = Math.Floor(distance / 15);
            double SecLost = (distance15 * 12.5);
            double time = (distance * SecForM) + SecLost;
            if (time < recordinSec)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(time - recordinSec):F2} seconds slower.");
            }
        }
    }
}
