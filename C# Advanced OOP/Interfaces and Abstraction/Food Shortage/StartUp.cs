using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var citizenBuyers = new List<Citizen>();
            var rebelBuyers = new List<Rebel>();

            for (int i = 0; i < n; i++)
            {
                var buyerInfo = Console.ReadLine().Split();
                var name = buyerInfo[0];
                var age = int.Parse(buyerInfo[1]);
                switch (buyerInfo.Length)
                {
                    case 4:
                        var id = buyerInfo[2];
                        var birthdate = buyerInfo[3];
                        var currentCitizen = new Citizen(name, age, id, birthdate);
                        citizenBuyers.Add(currentCitizen);
                        break;
                    case 3:
                        var group = buyerInfo[2];
                        var currentRebel = new Rebel(name, age, group);
                        rebelBuyers.Add(currentRebel);
                        break;
                }
            }
            var nameOfPerson = Console.ReadLine();
            while (nameOfPerson != "End")
            {
                var currentCitizen = citizenBuyers.FirstOrDefault(c => c.Name == nameOfPerson);
                var currentRebel = rebelBuyers.FirstOrDefault(r => r.Name == nameOfPerson);
                if (currentCitizen != null)
                {
                    currentCitizen.BuyFood();
                }
                else if (currentRebel != null)
                {
                    currentRebel.BuyFood();
                }
                nameOfPerson = Console.ReadLine();
            }
            Console.WriteLine(citizenBuyers.Sum(f => f.Food) + rebelBuyers.Sum(f => f.Food));
        }
    }
}
