using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            for (int i = floor; i >= 1; i--)
            {
                for (int j = 0; j < room; j++)
                {
                    if (i == floor)
                    {
                        Console.Write($"L{i}{j} ");                       
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");                       
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
