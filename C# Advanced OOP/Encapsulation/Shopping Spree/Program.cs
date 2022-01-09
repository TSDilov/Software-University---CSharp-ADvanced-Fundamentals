using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpreeEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            var namesInput = Console.ReadLine().Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            var productsInput = Console.ReadLine().Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < namesInput.Length - 1; i += 2)
            {
                var name = namesInput[i];
                var money = double.Parse(namesInput[i + 1]);
                try
                {
                    var person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }
            for (int i = 0; i < productsInput.Length - 1; i += 2)
            {
                var name = productsInput[i];
                var cost = double.Parse(productsInput[i + 1]);
                try
                {
                    var product = new Product(name, cost);
                    products.Add(product);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }
            var boughtCommand = Console.ReadLine();
            while (boughtCommand != "END")
            {
                var currentBought = boughtCommand.Split();
                var personName = currentBought[0];
                var productName = currentBought[1];

                Person person = people.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                person.BuyProduct(product);
                boughtCommand = Console.ReadLine();
            }
            foreach (var person in people)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ",person.Products)}");
                }
            }
        }
    }
}
