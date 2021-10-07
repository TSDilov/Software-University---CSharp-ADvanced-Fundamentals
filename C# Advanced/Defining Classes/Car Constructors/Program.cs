using System;

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
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            fuelConsumption = 10;
        }
        public Car(string make, string model, int year)
            :this()
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
    }
         public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);            
        }
    }
}
