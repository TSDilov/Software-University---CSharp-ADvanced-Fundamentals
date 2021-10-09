using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            List<Trainer> trainers = new List<Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = command[0];
                string pokemonName = command[1];
                string pokemonElement = command[2];
                int health = int.Parse(command[3]);
                var currentTreiner = new Trainer(trainerName);
                var currentPokemon = new Pokemon(pokemonName, pokemonElement, health);
                if (!trainers.Exists(t => t.Name == trainerName))
                {
                    trainers.Add(currentTreiner);
                }
                trainers.First(t => t.Name == trainerName).Pokemons.Add(currentPokemon);
            }
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, trainers.OrderByDescending(t => t.Badges)));
        }
    }
}
