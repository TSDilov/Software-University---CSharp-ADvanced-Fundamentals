using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpreeEncapsulation
{
    public class Product
    {
        private string name;
        private double cost;
        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name 
        {
            get => this.name;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public double Cost
        {
            get => this.cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.cost = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
