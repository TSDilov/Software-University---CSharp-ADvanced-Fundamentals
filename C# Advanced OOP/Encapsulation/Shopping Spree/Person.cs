using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpreeEncapsulation
{
    public class Person
    {
        private string name;
        private double money;
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }

        public string Name 
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public double Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public List<Product> Products { get; set; }
        public void BuyProduct(Product product)
        {
            if (this.Money - product.Cost >= 0)
            {
                this.Money -= product.Cost;
                this.Products.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
