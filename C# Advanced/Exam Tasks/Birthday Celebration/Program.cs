using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            var eatingCapacityOfGuest = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var plates = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            var wastedFood = 0;

            while (eatingCapacityOfGuest.Count != 0 && plates.Count != 0)
            {
                var currentCapacity = eatingCapacityOfGuest.Peek();
                var currentPlate = plates.Peek();
                if (currentPlate > currentCapacity)
                {
                    eatingCapacityOfGuest.Dequeue();
                    plates.Pop();
                    currentPlate -= currentCapacity;
                    wastedFood += currentPlate;
                }
                else if (currentCapacity > currentPlate)
                {
                    plates.Pop();
                    currentCapacity -= currentPlate;
                    eatingCapacityOfGuest.Dequeue();
                    eatingCapacityOfGuest.Enqueue(currentCapacity);
                    for (int i = 0; i < eatingCapacityOfGuest.Count - 1; i++)
                    {
                        var element = eatingCapacityOfGuest.Dequeue();
                        eatingCapacityOfGuest.Enqueue(element);
                    }
                }
                else
                {
                    eatingCapacityOfGuest.Dequeue();
                    plates.Pop();
                }
            }
            if (eatingCapacityOfGuest.Count > 0)
            {
                Console.Write("Guests:");
                foreach (var guest in eatingCapacityOfGuest)
                {
                    Console.Write($" {guest}");
                }
                Console.WriteLine();
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
            if (plates.Count > 0)
            {
                Console.Write("Plates:");
                foreach (var plate in plates)
                {
                    Console.Write($" {plate}");
                }
                Console.WriteLine();
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
        }
    }
}
