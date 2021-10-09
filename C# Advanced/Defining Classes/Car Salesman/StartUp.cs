﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine currentEngine = new Engine(engineInfo[0], engineInfo[1]);
                try
                {
                    if (Int32.TryParse(engineInfo[2], out _))
                    {
                        currentEngine.Displacement = engineInfo[2];
                    }
                    else
                    {
                        currentEngine.Efficiency = engineInfo[2];
                    }
                    if (Int32.TryParse(engineInfo[3], out _))
                    {
                        currentEngine.Displacement = engineInfo[3];
                    }
                    else
                    {
                        currentEngine.Efficiency = engineInfo[3];
                    }
                }
                catch (Exception)
                {

                }
                engines.Add(currentEngine);
            }

            int numberOFCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOFCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car currentCar = new Car(carInfo[0], engines.First(e => e.Model == carInfo[1]));

                try
                {
                    if (Int32.TryParse(carInfo[2], out _))
                    {
                        currentCar.Weight = carInfo[2];
                    }
                    else
                    {
                        currentCar.Color = carInfo[2];
                    }
                    if (Int32.TryParse(carInfo[3], out _))
                    {
                        currentCar.Weight = carInfo[3];
                    }
                    else
                    {
                        currentCar.Color = carInfo[3];
                    }

                }
                catch (Exception)
                {

                }
                cars.Add(currentCar);
            }
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
