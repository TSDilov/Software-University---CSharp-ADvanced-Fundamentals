using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (projection=="Premiere")
            {
                Console.WriteLine($"{r*c*12:F2} leva");
            }
            else if (projection=="Normal")
            {
                Console.WriteLine($"{r * c * 7.5:F2} leva");
            }
            else if (projection=="Discount")
            {
                Console.WriteLine($"{r * c * 5:F2} leva");
            }
        }
    }
}
