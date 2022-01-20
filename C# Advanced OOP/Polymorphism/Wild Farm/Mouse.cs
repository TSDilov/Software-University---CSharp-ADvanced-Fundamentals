using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        private const double WeightIncrease = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
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
            return "Squeak";
        }
        private bool ValidateFood(string food)
        {
            if (food == "Fruit" || food == "Vegetable")
            {
                return true;
            }
            throw new InvalidOperationException($"{GetType().Name} does not eat {food}!");
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
