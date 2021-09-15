    using System;

    namespace Cake
    {
        class Program
        {
            static void Main(string[] args)
            {
                int lenght = int.Parse(Console.ReadLine());
                int weigh = int.Parse(Console.ReadLine());
                int size = lenght * weigh;
                int piece = 0;
                string input;
                while (size >= piece)
                {
                    input = Console.ReadLine();
                    if (input == "STOP")
                    {
                        break;
                    }
                piece += int.Parse(input);
            }
                int diff = size - piece;
                if (diff > 0)
                {
                    Console.WriteLine($"{diff} pieces are left.");
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(diff)} pieces more.");
                }

            }
        }
    }
