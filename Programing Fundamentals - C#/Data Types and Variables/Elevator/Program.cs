using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int cours = people / capacity;
            if (cours * capacity == people)
            {
                Console.WriteLine(cours);
            }
            else
            {
                Console.WriteLine(cours + 1);
            }
        }
    }
}
