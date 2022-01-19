using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> myHeroes = new List<BaseHero>();
            int countOfHeroes = int.Parse(Console.ReadLine());
            CollectMyHeroTeam(myHeroes, countOfHeroes);

            int bossPower = int.Parse(Console.ReadLine());
            foreach (var hero in myHeroes)
            {
                Console.WriteLine(hero.CastAbility());
            }
            Console.WriteLine(myHeroes.Sum(h => h.Power) >= bossPower ? "Victory!" : "Defeat...");
        }

        private static void CollectMyHeroTeam(List<BaseHero> myHeroes, int countOfHeroes)
        {
            while (myHeroes.Count < countOfHeroes)
            {
                IHeroCreator heroCreator = null;
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();               
                switch (heroType.ToLower())
                {
                    case "druid":
                        heroCreator = new Druid(heroName);
                        break;
                    case "paladin":
                        heroCreator = new Paladin(heroName);
                        break;
                    case "rogue":
                        heroCreator = new Rogue(heroName);
                        break;
                    case "warrior":
                        heroCreator = new Warrior(heroName);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }

                if (heroCreator != null)
                {
                    BaseHero currentHero = heroCreator.GetHero();
                    myHeroes.Add(currentHero);
                }
            }
        }
    }
}
