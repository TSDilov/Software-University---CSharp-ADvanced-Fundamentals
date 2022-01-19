using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumptionPerKm { get; }
        double TankCapacity { get; }
        void Drive(double distance);
        void Refuel(double litters);
    }
}
