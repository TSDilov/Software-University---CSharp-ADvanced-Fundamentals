using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] data = input.Split();
                Item item = new Item();
                Box box = new Box();
                box.SerialNumber = data[0];
                item.Name = data[1];
                box.ItemQuantity = int.Parse(data[2]);
                item.Price = double.Parse(data[3]);
                box.BoxPrice = box.ItemQuantity * item.Price;
                box.Item = item;
                boxes.Add(box);
            }
            boxes = boxes.OrderByDescending(b => b.BoxPrice).ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }
    class Item 
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }
    class Box 
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double BoxPrice { get; set; }
    }
}
