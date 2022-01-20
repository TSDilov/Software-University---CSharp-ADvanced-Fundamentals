using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        private const double WeightIncrease = 0.40;
        public Dog(string name, double weight, string livingRegion)
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
            return "Woof!";
        }
        private bool ValidateFood(string food)
        {
            if (food == "Meat")
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
