using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            var endCommand = Console.ReadLine();

            while (endCommand != "End")
            {
                var currentAnimalInfo = endCommand.Split();
                var currentFoodInfo = Console.ReadLine().Split();

                var animalType = currentAnimalInfo[0];
                var animalName = currentAnimalInfo[1];
                var animalWeight = double.Parse(currentAnimalInfo[2]);
                var foodType = currentFoodInfo[0];
                var foodQuantity = int.Parse(currentFoodInfo[1]);
                Animal currentAnimal = null;
                currentAnimal = InitializeAnimal(currentAnimalInfo, animalType, animalName, animalWeight, currentAnimal);

                Food currentFood = null;
                currentFood = InitializeFood(foodType, foodQuantity, currentFood);

                Console.WriteLine(currentAnimal.ProduceSound());
                try
                {
                    currentAnimal.Eat(currentFood);
                }
                catch (InvalidOperationException iOpEx)
                {
                    Console.WriteLine(iOpEx.Message);
                }

                animals.Add(currentAnimal);
                endCommand = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food InitializeFood(string foodType, int foodQuantity, Food currentFood)
        {
            switch (foodType)
            {
                case "Vegetable":
                    currentFood = new Vegetable(foodQuantity);
                    break;
                case "Fruit":
                    currentFood = new Fruit(foodQuantity);
                    break;
                case "Meat":
                    currentFood = new Meat(foodQuantity);
                    break;
                case "Seeds":
                    currentFood = new Seeds(foodQuantity);
                    break;
            }

            return currentFood;
        }

        private static Animal InitializeAnimal(string[] currentAnimalInfo, string animalType, string animalName, double animalWeight, Animal currentAnimal)
        {
            switch (animalType)
            {
                case "Owl":
                    var wingSize = double.Parse(currentAnimalInfo[3]);
                    currentAnimal = new Owl(animalName, animalWeight, wingSize);
                    break;
                case "Hen":
                    wingSize = double.Parse(currentAnimalInfo[3]);
                    currentAnimal = new Hen(animalName, animalWeight, wingSize);
                    break;
                case "Mouse":
                    var livingRegion = currentAnimalInfo[3];
                    currentAnimal = new Mouse(animalName, animalWeight, livingRegion);
                    break;
                case "Dog":
                    livingRegion = currentAnimalInfo[3];
                    currentAnimal = new Dog(animalName, animalWeight, livingRegion);
                    break;
                case "Cat":
                    livingRegion = currentAnimalInfo[3];
                    var breed = currentAnimalInfo[4];
                    currentAnimal = new Cat(animalName, animalWeight, livingRegion, breed);
                    break;
                case "Tiger":
                    livingRegion = currentAnimalInfo[3];
                    breed = currentAnimalInfo[4];
                    currentAnimal = new Tiger(animalName, animalWeight, livingRegion, breed);
                    break;
            }

            return currentAnimal;
        }
    }
}
