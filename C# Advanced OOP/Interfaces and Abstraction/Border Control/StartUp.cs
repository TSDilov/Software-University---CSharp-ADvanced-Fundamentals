using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var detained = new List<IIdentifiable>();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var borderControlCheck = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = borderControlCheck[0];
                switch (borderControlCheck.Length)
                {
                    case 3:
                        var age = int.Parse(borderControlCheck[1]);
                        var id = borderControlCheck[2];
                        var currentCitizen = new Citizen(name, age, id);
                        detained.Add(currentCitizen);
                        break;
                    case 2:
                        var robotID = borderControlCheck[1];
                        var currentRobot = new Robot(name, robotID);
                        detained.Add(currentRobot);
                        break;
                }
                command = Console.ReadLine();
            }
            var endingIDNumberForDetained = Console.ReadLine();
            detained = detained.Where(c => c.Id.EndsWith(endingIDNumberForDetained)).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, detained.Select(c => c.Id)));
        }
    }
}
