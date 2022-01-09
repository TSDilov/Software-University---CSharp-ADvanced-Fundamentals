using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private Dictionary<string, double> flourCalories = new Dictionary<string, double>
        {
            { "white", 1.5 },
            { "wholegrain", 1 }
        };
        private Dictionary<string, double> bakingTechniqueCalories = new Dictionary<string, double>
        {
            { "crispy", 0.9 },
            { "chewy", 1.1},
            { "homemade", 1}
        };
        private string flourType;
        private string bakingTechnique;
        private double weight;
        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public string FlourType
        {
            get => this.flourType; 
            private set 
            {
                if (!flourCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value; 
            }
        }
        public string BakingTechnique
        {
            get => this.bakingTechnique; 
            private set 
            {
                if (!bakingTechniqueCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value; 
            }
        }
        public double Weight
        {
            get => this.weight; 
            private set 
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range[1..200].");
                }
                this.weight = value; 
            }
        }
        public double Calories 
            => 2 * Weight * this.flourCalories[this.FlourType.ToLower()] * this.bakingTechniqueCalories[this.BakingTechnique.ToLower()];
    }
}
