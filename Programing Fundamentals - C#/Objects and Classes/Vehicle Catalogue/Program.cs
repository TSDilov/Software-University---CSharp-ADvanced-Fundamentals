using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog vehicleCatalog = new Catalog();
            vehicleCatalog.Cars = new List<Car>();
            vehicleCatalog.Trucks = new List<Truck>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] vehicleData = input.Split('/');

                if (vehicleData[0] == "Truck")
                {
                    Truck newTruck = new Truck();
                    newTruck.Brand = vehicleData[1];
                    newTruck.Model = vehicleData[2];
                    newTruck.Weight = vehicleData[3];
                    vehicleCatalog.Trucks.Add(newTruck);
                }
                else if (vehicleData[0] == "Car")
                {
                    Car newCar = new Car();
                    newCar.Brand = vehicleData[1];
                    newCar.Model = vehicleData[2];
                    newCar.HorsePower = vehicleData[3];
                    vehicleCatalog.Cars.Add(newCar);
                }
            }

            if (vehicleCatalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in vehicleCatalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (vehicleCatalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in vehicleCatalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Truck 
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string HorsePower { get; set; }
    }
    class Catalog 
    {
        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }
}
