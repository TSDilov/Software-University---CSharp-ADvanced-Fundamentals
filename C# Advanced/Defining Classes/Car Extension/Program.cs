using System;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        public string Make
        {
            get => make;
            set { make = value; }
        }

        private string model;
        public string Model
        {
            get => model;
            set { model = value; }
        }

        private int year;
        public int Year
        {
            get => year;
            set { year = value; }
        }
        private double fuelQuantity;
        public double FuelQuantity 
        {
            get => fuelQuantity;
            set { fuelQuantity = value; }               
        }

        private double fuelConsumption;

        public double FuelConsumption
        {
            get => fuelConsumption;
            set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            double fuelConsumed = (distance / 100) * fuelConsumption;
            if (fuelQuantity - fuelConsumed >= 0)
            {
                fuelQuantity -= fuelConsumed;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"Make: {make}\nModel: {model}\nYear: {year}\nFuel: {fuelQuantity:F2}");
            return message.ToString();
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
