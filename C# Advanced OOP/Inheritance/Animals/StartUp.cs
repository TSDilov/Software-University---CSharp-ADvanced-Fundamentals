using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>();
            var typeOfAnimal = Console.ReadLine();

            while (typeOfAnimal != "Beast!")
            {
                var animalInfo = Console.ReadLine().Split();
                var name = animalInfo[0];
                var age = int.Parse(animalInfo[1]);
                var gender = animalInfo[2];

                if (typeOfAnimal == "Dog")
                {
                    var dog = new Dog(name, age, gender);
                    animals.Add(dog);                    
                }
                else if (typeOfAnimal == "Cat")
                {
                    var cat = new Cat(name, age, gender);
                    animals.Add(cat);
                }
                else if (typeOfAnimal == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    animals.Add(kitten);
                }
                else if (typeOfAnimal == "Tomcat")
                {
                    var tomcat = new Tomcat(name, age);
                    animals.Add(tomcat);
                }
                else if (typeOfAnimal == "Frog")
                {
                    var frog = new Frog(name, age, gender);
                    animals.Add(frog);
                }
                typeOfAnimal = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound() );
            }
        }
    }
}
