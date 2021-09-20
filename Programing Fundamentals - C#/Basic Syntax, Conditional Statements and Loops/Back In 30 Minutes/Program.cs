using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int minAll = hour * 60 + min;
            int hourNew = (minAll + 30) / 60;
            int minNew = (minAll + 30) % 60;
            if (minAll >= 1410)
            {
                hourNew = 0;
            }
            Console.WriteLine($"{hourNew}:{minNew:D2}");
        }
    }
}
