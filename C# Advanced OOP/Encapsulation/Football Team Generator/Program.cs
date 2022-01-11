using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            var command = Console.ReadLine().Split(";");

            while (command[0] != "END")
            {
                var currentAction = command[0];
                try
                {
                    if (currentAction == "Team")
                    {
                        var nameOfTeam = command[1];
                        var team = new Team(nameOfTeam);
                        teams.Add(nameOfTeam, team);
                    }
                    else if (currentAction == "Add")
                    {
                        var nameOfTeam = command[1];
                        if (!teams.ContainsKey(nameOfTeam))
                        {
                            Console.WriteLine($"Team {nameOfTeam} does not exist.");
                            command = Console.ReadLine().Split(";");
                            continue;
                        }
                        var playerName = command[2];
                        int endurance = int.Parse(command[3]);
                        int sprint = int.Parse(command[4]);
                        int dribble = int.Parse(command[5]);
                        int passing = int.Parse(command[6]);
                        int shooting = int.Parse(command[7]);
                        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        teams[nameOfTeam].AddPlayer(player);
                    }
                    else if (currentAction == "Remove")
                    {
                        var nameOfTeam = command[1];
                        var playerName = command[2];
                        teams[nameOfTeam].RemovePlayer(playerName);
                    }
                    else if (currentAction == "Rating")
                    {
                        var nameOfTeam = command[1];
                        if (!teams.ContainsKey(nameOfTeam))
                        {
                            Console.WriteLine($"Team {nameOfTeam} does not exist.");
                            command = Console.ReadLine().Split(";");
                            continue;
                        }
                        Console.WriteLine($"{nameOfTeam} - {teams[nameOfTeam].Rating}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine().Split(";");
            }
        }
    }
}
