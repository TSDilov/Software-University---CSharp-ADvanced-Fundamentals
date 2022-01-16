using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var soldiers = new List<Soldier>();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var typeOfSoldier = command.Split();
                var soldierType = typeOfSoldier[0];
                var id = typeOfSoldier[1];
                var firstName = typeOfSoldier[2];
                var lastName = typeOfSoldier[3];

                if (soldierType == "Private")
                {
                    decimal salary = decimal.Parse(typeOfSoldier[4]);
                    var currentPrivate = new Private(id, firstName, lastName, salary);
                    soldiers.Add(currentPrivate);
                }
                else if (soldierType == "LieutenantGeneral")
                {
                    var salary = decimal.Parse(typeOfSoldier[4]);
                    List<string> privates = typeOfSoldier.Skip(5).ToList();
                    var currentLieutenant = new LieutenantGeneral(id, firstName, lastName, salary);
                    while (privates.Any())
                    {
                        Private currentPrivate = (Private)soldiers.FirstOrDefault(s => s.Id == privates[0]);
                        if (currentPrivate != null)
                        {
                            currentLieutenant.PrivatesUnderCommand.Add(currentPrivate);
                        }
                        privates.RemoveAt(0);
                    }
                    soldiers.Add(currentLieutenant);
                }
                else if (soldierType == "Engineer")
                {
                    var salary = decimal.Parse(typeOfSoldier[4]);
                    var corps = typeOfSoldier[5];
                    try
                    {
                        var currentEngineer = new Engineer(id, firstName, lastName, salary, corps);
                        List<string> repairs = typeOfSoldier.Skip(6).ToList();
                        while (repairs.Any())
                        {
                            var repairName = repairs[0];
                            var repairTime = int.Parse(repairs[1]);
                            var currentRepair = new Repair(repairName, repairTime);
                            currentEngineer.Repairs.Add(currentRepair);
                            repairs.RemoveRange(0, 2);
                        }
                        soldiers.Add(currentEngineer);
                    }
                    catch (ArgumentException ae)
                    {
                    }
                }
                else if (soldierType == "Commando")
                {
                    var salary = decimal.Parse(typeOfSoldier[4]);
                    var corps = typeOfSoldier[5];
                    List<string> missions = typeOfSoldier.Skip(6).ToList();
                    var currentCommando = new Commando(id, firstName, lastName, salary, corps);
                    while (missions.Any())
                    {
                        try
                        {
                            string missionCodeName = missions[0];
                            string missionState = missions[1];
                            var currentMission = new Mission(missionState, missionCodeName);
                            currentCommando.Missions.Add(currentMission);
                        }
                        catch (ArgumentException ae)
                        {
                        }
                        missions.RemoveRange(0, 2);
                    }
                    soldiers.Add(currentCommando);
                }
                else if (soldierType == "Spy")
                {
                    var codeNumber = int.Parse(typeOfSoldier[4]);
                    var currentSpy = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(currentSpy);
                }

                command = Console.ReadLine();
            }
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
