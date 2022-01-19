using System;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            var truckInfo = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            var busInfo = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();

            var carFuelQuantity = carInfo[0];
            var carFuelConsumptionPerKm = carInfo[1];
            var carTankCapacity = carInfo[2];
            IVehicle car = new Car(carFuelQuantity, carFuelConsumptionPerKm, carTankCapacity);

            var truckFuelQuantity = truckInfo[0];
            var truckFuelConsumptionPerKm = truckInfo[1];
            var truckTankCapacity = truckInfo[2];
            IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumptionPerKm, truckTankCapacity);

            var busFuelQuantity = busInfo[0];
            var busFuelConsumptionPerKm = busInfo[1];
            var busTankCapacity = busInfo[2];
            IVehicle bus = new Bus(busFuelQuantity, busFuelConsumptionPerKm, busInfo[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var currentCommand = Console.ReadLine().Split();
                var driveOrRefuel = currentCommand[0];
                var typeOfVehicle = currentCommand[1];
                var distanceToDriveOrFuelToRefuel = double.Parse(currentCommand[2]);
                MethodForMoveOrRefuel(car, truck, bus, driveOrRefuel, typeOfVehicle, distanceToDriveOrFuelToRefuel);
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        private static void MethodForMoveOrRefuel(IVehicle car, IVehicle truck, IVehicle bus, string driveOrRefuel, string typeOfVehicle, double distanceToDriveOrFuelToRefuel)
        {
            if (driveOrRefuel == "Drive")
            {
                if (typeOfVehicle == "Car")
                {
                    car.Drive(distanceToDriveOrFuelToRefuel);
                }
                else if (typeOfVehicle == "Truck")
                {
                    truck.Drive(distanceToDriveOrFuelToRefuel);
                }
                else if (typeOfVehicle == "Bus")
                {
                    bus.Drive(distanceToDriveOrFuelToRefuel);
                }
            }
            else if (driveOrRefuel == "Refuel")
            {
                if (typeOfVehicle == "Car")
                {
                    car.Refuel(distanceToDriveOrFuelToRefuel);
                }
                else if (typeOfVehicle == "Truck")
                {
                    truck.Refuel(distanceToDriveOrFuelToRefuel);
                }
                else if (typeOfVehicle == "Bus")
                {
                    bus.Refuel(distanceToDriveOrFuelToRefuel);
                }
            }
            else if (driveOrRefuel == "DriveEmpty")
            {
                if (bus is Bus)
                {
                    ((Bus)bus).DriveEmpty(distanceToDriveOrFuelToRefuel);
                }
            }
        }
    }
}
