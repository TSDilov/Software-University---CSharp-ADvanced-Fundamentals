using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public void Add(Ingredient ingredient)
        {
            if (Ingredients.Count < Capacity && !Ingredients.Any(c => c.Name == ingredient.Name))
            {
                Ingredients.Add(ingredient);
            }
        }
        public bool Remove(string name)
        {
            var cocktail = Ingredients.FirstOrDefault(c => c.Name == name);
            if (cocktail == null)
            {
                return false;
            }
            else
            {
                Ingredients.Remove(cocktail);
                return true;
            }
        }
        public Ingredient FindIngredient(string name)
        {
            return Ingredients.FirstOrDefault(c => c.Name == name);
        }
        public Ingredient GetMostAlcoholicIngredient()
        {
            return Ingredients.OrderByDescending(c => c.Alcohol).FirstOrDefault();
        }
        public int CurrentAlcoholLevel => Ingredients.Sum(c => c.Alcohol);
        public string Report()
        {
            var report = new StringBuilder();
            report.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (var ingredient in Ingredients)
            {
                report.AppendLine(ingredient.ToString());               
            }
            return report.ToString().TrimEnd();
        }
    }
}
