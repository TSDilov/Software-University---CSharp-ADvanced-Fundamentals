using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVehicle
    {
        private const double SummerFuelConsumptionModifier = 1.6;
        private const double TinyHoleInTankModifier = 0.95;
        private double fuelConsumptionPerKm;
        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
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
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumptionPerKm
        {
            get => this.fuelConsumptionPerKm + SummerFuelConsumptionModifier;
            private set => this.fuelConsumptionPerKm = value;
        }

        public double TankCapacity { get; private set; }

        public void Drive(double distance)
        {
            if (this.FuelConsumptionPerKm * distance <= FuelQuantity)
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
            if (this.FuelQuantity + (litters * TinyHoleInTankModifier) > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {litters} fuel in the tank");
                return;
            }
            this.FuelQuantity = this.FuelQuantity + (litters * TinyHoleInTankModifier);
        }
    }
}
