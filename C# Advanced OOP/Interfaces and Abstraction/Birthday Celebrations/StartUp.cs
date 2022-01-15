using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var citizenOrPetWithLookingYear = new List<IBirthable>();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var currentCitizenOrRobotOrPet = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var type = currentCitizenOrRobotOrPet[0];
                var name = currentCitizenOrRobotOrPet[1];
                switch (type)
                {
                    case "Citizen":
                        var age = int.Parse(currentCitizenOrRobotOrPet[2]);
                        var id = currentCitizenOrRobotOrPet[3];
                        var birthdate = currentCitizenOrRobotOrPet[4];
                        var currentCitizen = new Citizen(name, age, id, birthdate);
                        citizenOrPetWithLookingYear.Add(currentCitizen);
                        break;
                    case "Pet":
                        birthdate = currentCitizenOrRobotOrPet[2];
                        var currentPet = new Pet(name, birthdate);
                        citizenOrPetWithLookingYear.Add(currentPet);
                        break;
                }
                command = Console.ReadLine();
            }
            var yearForLookingType = Console.ReadLine();
            foreach (var type in citizenOrPetWithLookingYear)
            {
                if (type.Birthdate.EndsWith(yearForLookingType))
                {
                    Console.WriteLine(type.Birthdate);
                }
            }
        }
    }
}
