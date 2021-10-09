using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            cars = new List<Car>();
            Capacity = capacity;
        }
        public List<Car> MyProperty { get => cars; set => cars = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int Count
            => cars.Count();
        public string AddCar(Car car)
        {
            if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Count == capacity )
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            if (!cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.Remove(cars.First(c => c.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }
        }
        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                cars.RemoveAll(c => c.RegistrationNumber == registrationNumber);
            }
        }
    }

}
