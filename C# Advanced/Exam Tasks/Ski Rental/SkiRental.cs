using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            skies = new List<Ski>();
        }
        private List<Ski> skies;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => skies.Count();
        public void Add(Ski ski)
        {
            if (skies.Count < Capacity)
            {
                skies.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            var ski = skies.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);
            if (ski == null)
            {
                return false;
            }
            else
            {
                skies.Remove(ski);
                return true;
            }
        }
        public Ski GetNewestSki()
        {
            return skies.OrderByDescending(s => s.Year).FirstOrDefault();
        }
        public Ski GetSki(string manufacturer, string model)
        { 
            var ski = skies.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);
            return ski;
        }
        public string GetStatistics()
        {
            StringBuilder statistics = new StringBuilder();
            statistics.AppendLine($"The skis stored in {Name}:");
            foreach (var ski in skies)
            {
                statistics.AppendLine(ski.ToString());
            }
            return statistics.ToString();
        }
    }
}
