using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroesHP = new Dictionary<string, int>();
            Dictionary<string, int> heroesMP = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] heroesPoint = Console.ReadLine().Split();
                string name = heroesPoint[0];
                int hp = int.Parse(heroesPoint[1]);
                int mp = int.Parse(heroesPoint[2]);

                heroesHP.Add(name, hp);
                heroesMP.Add(name, mp);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currentCommand = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                switch (currentCommand[0])
                {
                    case "CastSpell":
                        string heroName = currentCommand[1];
                        int MPneeded = int.Parse(currentCommand[2]);
                        string spellName = currentCommand[3];
                        if (heroesMP[heroName] < MPneeded)
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        else
                        {
                            heroesMP[heroName] -= MPneeded;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesMP[heroName]} MP!");
                        }
                        break;
                    case "TakeDamage":
                        heroName = currentCommand[1];
                        int damage = int.Parse(currentCommand[2]);
                        string attacker = currentCommand[3];
                        if (heroesHP[heroName] <= damage)
                        {
                            heroesHP[heroName] = 0;
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");                            
                        }
                        else
                        {
                            heroesHP[heroName] -= damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHP[heroName]} HP left!");
                        }
                        break;
                    case "Recharge":
                        heroName = currentCommand[1];
                        int amount = int.Parse(currentCommand[2]);
                        if (heroesMP[heroName] + amount > 200)
                        {
                            Console.WriteLine($"{heroName} recharged for {200 - heroesMP[heroName]} MP!");
                            heroesMP[heroName] = 200;
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} recharged for {amount} MP!");
                            heroesMP[heroName] += amount;
                        }
                        break;
                    case "Heal":
                        heroName = currentCommand[1];
                        amount = int.Parse(currentCommand[2]);
                        if (heroesHP[heroName] + amount > 100)
                        {
                            Console.WriteLine($"{heroName} healed for {100 - heroesHP[heroName]} HP!");
                            heroesHP[heroName] = 100;
                        }
                        else
                        {
                            heroesHP[heroName] += amount;
                            Console.WriteLine($"{heroName} healed for {amount} HP!");
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            heroesHP = heroesHP
                .Where(h => h.Value > 0)
                .OrderByDescending(h => h.Value)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);
            foreach (var hero in heroesHP)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"HP: {hero.Value}");
                Console.WriteLine($"MP: {heroesMP[hero.Key]}");
            }
        }
    }
}
