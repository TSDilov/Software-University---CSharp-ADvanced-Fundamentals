
using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("Mercedes", "CLK", 8, 60);
        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CtorThrowExceptionForNullOrEmptyMake(string make)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, "CLK", 8, 60));
        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CtorThrowExceptionForNullOrEmptyModel(string model)
        {
            Assert.Throws<ArgumentException>(() => new Car("Mercedes", model, 8, 60));
        }
        [Test]
        [TestCase(0.0)]
        [TestCase(-1.0)]
        public void CtorThrowExceptionForZeroORNegativeFuelConsumprion(double consumption)
        {
            Assert.Throws<ArgumentException>(() => new Car("Mercedes", "CLK", consumption, 60));
        }
        [Test]
        [TestCase(0.0)]
        [TestCase(-1.0)]
        public void CtorThrowExceptionForZeroORNegativeFuelCapacity(double capacity)
        {
            Assert.Throws<ArgumentException>(() => new Car("Mercedes", "CLK", 8, capacity));
        }
        [Test]
        public void CtorCreateNewCar()
        {
            Assert.AreEqual("Mercedes", car.Make);
            Assert.AreEqual("CLK", car.Model);
            Assert.AreEqual(8, car.FuelConsumption);
            Assert.AreEqual(60, car.FuelCapacity);
        }
        [Test]
        [TestCase(0.0)]
        [TestCase(-1.0)]
        public void RefuelThrowExceptionForNegativiOrZeroFuelTORefuel(double fuelToRefuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }
        [Test]
        public void RefuelWithAmountLessThanCapacity()
        {
            var currentAmount = car.FuelAmount;
            car.Refuel(20);
            Assert.AreEqual(car.FuelAmount, currentAmount + 20);
        }
        [Test]
        public void RefuelWithAmountMoreThanCapacity()
        {
            car.Refuel(65);
            Assert.AreEqual(car.FuelAmount, 60);
        }
        [Test]
        public void DriveThrowExceptionForNotEnoughFuel()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(5));  
        }
        [Test]
        public void DriveWithEnoughFuel()
        {
            car.Refuel(40);
            car.Drive(100);
            Assert.AreEqual(32, car.FuelAmount);
        }
    }
}