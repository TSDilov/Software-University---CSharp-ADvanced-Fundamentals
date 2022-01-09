using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public Pizza(string name)
        {
            this.Name = name;
            toppings = new List<Topping>();
        }
        public string Name
        {
            get => this.name;
            private set 
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value; 
            }
        }
        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }
        public double Calories => this.CalculateCalories();
        public void AddTopping(Topping topping)
        {
            if (toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }
        
        private double CalculateCalories()
        {
            double totalCalories = this.dough.Calories;
            foreach (var topping in toppings)
            {
                totalCalories += topping.Calories;
            }
            return totalCalories;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Calories:F2} Calories.";
        }
    }
}
