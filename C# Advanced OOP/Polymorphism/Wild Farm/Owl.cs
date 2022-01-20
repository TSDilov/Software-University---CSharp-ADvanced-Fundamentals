using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        private const double WeightIncrease = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }
        public override void Eat(Food food)
        {
            if (ValidateFood(food.GetType().Name))
            {
                this.Weight += WeightIncrease * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
        private bool ValidateFood(string food)
        {
            if (food == "Meat")
            {
                return true;
            }
            throw new InvalidOperationException($"{GetType().Name} does not eat {food}!");
        }
    }
}
