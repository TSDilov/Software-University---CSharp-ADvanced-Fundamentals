using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOFCarsThatMoveInGreen = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passed = 0;
            while (true)
            {
                string pointer = Console.ReadLine();
                if (pointer == "end")
                {
                    break;
                }
                else if (pointer == "green")
                {
                    for (int i = 0; i < numberOFCarsThatMoveInGreen; i++)
                    {
                        if (cars.Count > 0)
                        {
                            string car = cars.Dequeue();
                            Console.WriteLine(car + " passed!");
                            passed++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(pointer);
                }
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
