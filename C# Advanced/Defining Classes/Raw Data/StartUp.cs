using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int speed = int.Parse(carInfo[1]);
                int power = int.Parse(carInfo[2]);
                int weight = int.Parse(carInfo[3]);
                string type = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);
                Engine currentEngine = new Engine(speed, power);
                Cargo currentCargo = new Cargo(weight, type);
                Tire tire1 = new Tire(tire1Age, tire1Pressure);
                Tire tire2 = new Tire(tire1Age, tire1Pressure);
                Tire tire3 = new Tire(tire1Age, tire1Pressure);
                Tire tire4 = new Tire(tire1Age, tire1Pressure);
                List<Tire> tires = new List<Tire>();
                tires.Add(tire1);
                tires.Add(tire2);
                tires.Add(tire3);
                tires.Add(tire4);
                Car currentCar = new Car(model, currentEngine, currentCargo, tires);
                cars.Add(currentCar);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars.FindAll(c => c.Cargo.Type == "fragile" && 
                c.Tires.Any(t => t.Pressure < 1))));
            }
            else if (command == "flammable")
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars.FindAll(c => c.Cargo.Type == "flammable" &&
                c.Engine.Power > 250)));
            }
        }
    }
}
