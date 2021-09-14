using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            string stop = Console.ReadLine();
            while (stop != "Stop")
            {
                int num = int.Parse(stop);
                if (num < min)
                {
                    min = num;
                }
                stop = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
