using System;

namespace Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double bugFilm = double.Parse(Console.ReadLine());
            int numStatists = int.Parse(Console.ReadLine());
            double sumDressStatist = double.Parse(Console.ReadLine());
            double sumDressStatistAll = sumDressStatist * numStatists;
            double sumDecor = bugFilm * 1 / 10;
            if (numStatists > 150)
            {
                sumDressStatistAll -= sumDressStatistAll * 1 / 10;
            }
            if ((sumDressStatistAll + sumDecor) > bugFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {((sumDecor + sumDressStatistAll) - bugFilm):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(bugFilm - (sumDressStatistAll + sumDecor)):F2} leva left.");
            }
        }
    }
}
