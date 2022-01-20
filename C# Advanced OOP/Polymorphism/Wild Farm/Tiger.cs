using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        private const double WeightIncrease = 1.0;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
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
            return "ROAR!!!";
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
