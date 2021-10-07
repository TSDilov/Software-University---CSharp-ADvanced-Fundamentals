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

        private Engine engine;
        public Engine Engine { get => engine; set { engine = value; } }
        private Tire[] tires;
        public Tire[] Tires { get => tires; set { tires = value; } }
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            fuelConsumption = 10;
        }
        public Car(string make, string model, int year)
            : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
           : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
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
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
        public int HorsePower { get => horsePower; set { horsePower = value; } }
        public double CubicCapacity { get => cubicCapacity; set { cubicCapacity = value; } }
    }
    public class Tire 
    {
        private int year;
        private double pressure;

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        public int Year { get => year; set { year = value; } }
        public double Pressure { get => pressure; set { pressure = value; } }

    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            
        }
    }
}
