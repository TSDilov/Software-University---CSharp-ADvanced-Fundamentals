using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CofeeeMilliliters = 50;
        private const decimal CoffeePrice = 3.5m;
        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CofeeeMilliliters)
        {
            this.Caffeine = caffeine;
        }
        public double Caffeine  { get; set; }
    }
}
