using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        private const double WeightIncrease = 0.3;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow"; 
        }

        public override void Eat(Food food)
        {
            if (ValidateFood(food.GetType().Name))
            {
                this.Weight += WeightIncrease * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
        }

        private bool ValidateFood(string food)
        {
            if (food == "Vegetable" || food == "Meat")
            {
                return true;
            }
            throw new InvalidOperationException($"{GetType().Name} does not eat {food}!");
        }
    }
}
