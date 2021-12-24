using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            racers = new List<Racer>();
        }
        private List<Racer> racers;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => racers.Count;
        public void Add(Racer Racer)
        {
            if (racers.Count < Capacity)
            {
                racers.Add(Racer);
            }
        }
        public bool Remove(string name)
        {
            var racer = racers.FirstOrDefault(r => r.Name == name);
            if (racer == null)
            {
                return false;
            }
            else
            {
                racers.Remove(racer);
                return true;
            }
        }
        public Racer GetOldestRacer()
        {
            return racers.OrderByDescending(r => r.Age).FirstOrDefault();
        }
        public Racer GetRacer(string name)
        {
            return racers.FirstOrDefault(r => r.Name == name);
        }
        public Racer GetFastestRacer()
        {
            return racers.OrderByDescending(r => r.Car.Speed).FirstOrDefault();
        }
        public string Report()
        {
            var report = new StringBuilder();
            report.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in racers)
            {
                report.AppendLine(racer.ToString());
            }
            return report.ToString().TrimEnd();
        }
    }
}
