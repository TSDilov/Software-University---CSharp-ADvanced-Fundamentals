using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {

        }
        public Person(int age)
        {
            Age = age;
        }
        public Person(string name, int age)
            : this (age)
        {
            Name = name;
        }
        private string name;

        private int age;

        public string Name { get; set; } = "No name";
        public int Age { get; set; } = 1;
        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
}
