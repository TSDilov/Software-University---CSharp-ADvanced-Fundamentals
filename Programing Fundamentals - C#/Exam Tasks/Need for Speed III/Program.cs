using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedforSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> carsKilometers = new Dictionary<string, int>();
            Dictionary<string, int> carsFuelAvailable = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cars = Console.ReadLine().Split("|");
                carsKilometers.Add(cars[0], int.Parse(cars[1]));
                carsFuelAvailable.Add(cars[0], int.Parse(cars[2]));
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] currentCommand = command.Split(" : ");
                switch (currentCommand[0])
                {
                    case "Drive":
                        string car = currentCommand[1];
                        int distance = int.Parse(currentCommand[2]);
                        int fuelNeeded = int.Parse(currentCommand[3]);
                        if (fuelNeeded > carsFuelAvailable[car])
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                            carsKilometers[car] += distance;
                            carsFuelAvailable[car] -= fuelNeeded;
                            if (carsKilometers[car] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!");
                                carsKilometers.Remove(car);
                                carsFuelAvailable.Remove(car);
                            }
                        }
                        break;
                    case "Refuel":
                        car = currentCommand[1];
                        int fuel = int.Parse(currentCommand[2]);
                        int carFuelWithoutRefuel = carsFuelAvailable[car];
                        carsFuelAvailable[car] += fuel;
                        if (carsFuelAvailable[car] > 75)
                        {
                            fuel = 75 - carFuelWithoutRefuel;
                            carsFuelAvailable[car] = 75;
                        }
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                        break;
                    case "Revert":
                        car = currentCommand[1];
                        int kilometersToDecrease = int.Parse(currentCommand[2]);
                        carsKilometers[car] -= kilometersToDecrease;
                        if (carsKilometers[car] < 10000)
                        {
                            carsKilometers[car] = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{car} mileage decreased by {kilometersToDecrease} kilometers");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            foreach (var car in carsKilometers.OrderByDescending(c => c.Value).ThenBy(c => c.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carsFuelAvailable[car.Key]} lt.");
            }
        }
    }
}
