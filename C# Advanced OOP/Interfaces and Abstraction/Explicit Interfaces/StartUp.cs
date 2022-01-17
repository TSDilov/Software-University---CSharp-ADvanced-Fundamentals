using System;

namespace ExplicitInterfaces
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                var name = input[0];
                var country = input[1];
                var age = int.Parse(input[2]);
                var currentCitizen = new Citizen(name, country, age);
                Console.WriteLine(currentCitizen);
                input = Console.ReadLine().Split();
            }
        }
    }
}
