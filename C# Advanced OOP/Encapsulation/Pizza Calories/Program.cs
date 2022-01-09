using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentPizza = Console.ReadLine().Split();
            try
            {
                CreatePizza(currentPizza);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static void CreatePizza(string[] currentPizza)
        {
            var pizzaName = currentPizza[1];
            var pizza = new Pizza(pizzaName);
            currentPizza = Console.ReadLine().Split();
            var doughFlour = currentPizza[1];
            var doughbakingTechnique = currentPizza[2];
            var doughWeigh = double.Parse(currentPizza[3]);
            var pizzaDough = new Dough(doughFlour, doughbakingTechnique, doughWeigh);
            pizza.Dough = pizzaDough;
            currentPizza = Console.ReadLine().Split();
            while (currentPizza[0] != "END")
            {
                var pizzaTopping = new Topping(currentPizza[1], double.Parse(currentPizza[2]));
                pizza.AddTopping(pizzaTopping);
                currentPizza = Console.ReadLine().Split();
            }
            Console.WriteLine(pizza);
        }
    }
}
