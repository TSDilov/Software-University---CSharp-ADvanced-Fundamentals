using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public Player(string name, string myClass)
        {
            Name = name;
            MyClass = myClass;
        }
        public string Name { get; set; }
        public string MyClass { get; set; }
        public string Rank { get; set; } = "Trial";
        public string Description { get; set; } = "n/a";

        public override string ToString()
        {
            return @$"Player {Name}: {MyClass}
Rank: {Rank}
Description: {Description}";
        }
    }
}
