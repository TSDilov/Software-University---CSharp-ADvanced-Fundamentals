using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int size = width * lenght * height;
            bool hasSize = true;
            string command = Console.ReadLine();
            while (command != "Done")
            {
                int box = int.Parse(command);
                size -= box;
                if (size < 0)
                {
                    hasSize = false;
                    break;
                }
                command = Console.ReadLine();
            }
            if (hasSize)
                Console.WriteLine($"{size} Cubic meters left.");
            else
                Console.WriteLine($"No more free space! You need {Math.Abs(size)} Cubic meters more.");
        }
    }
}
