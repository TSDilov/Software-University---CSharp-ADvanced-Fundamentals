using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : IVehicle
    {
        private const double SummerFuelConsumptionModifier = 1.4;
        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            if (fuelQuantity <= TankCapacity)
            {
                this.FuelQuantity = fuelQuantity;
            }
            else
            {
                this.FuelQuantity = 0;
            }
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumptionPerKm { get; private set; }
        public double TankCapacity { get; private set; }

        public void Drive(double distance)
        {
            if ((this.FuelConsumptionPerKm + SummerFuelConsumptionModifier) * distance <= this.FuelQuantity)
            {
                this.FuelQuantity -= (this.FuelConsumptionPerKm + SummerFuelConsumptionModifier) * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
                return;
            }
            Console.WriteLine($"{GetType().Name} needs refueling");
        }

        public void DriveEmpty(double distance)
        {
            if (this.FuelConsumptionPerKm * distance <= this.FuelQuantity)
            {
                this.FuelQuantity -= this.FuelConsumptionPerKm * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
                return;
            }
            Console.WriteLine($"{GetType().Name} needs refueling");
        }

        public void Refuel(double litters)
        {
            if (litters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (this.FuelQuantity + litters > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {litters} fuel in the tank");
                return;
            }
            this.FuelQuantity += litters;
        }
    }
}
