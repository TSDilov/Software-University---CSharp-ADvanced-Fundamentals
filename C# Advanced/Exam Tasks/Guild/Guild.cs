using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
        private List<Player> players = new List<Player>();
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => players.Count;
        public void AddPlayer(Player player)
        {
            if (players.Count < Capacity)
            {
                players.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            var player = players.FirstOrDefault(p => p.Name == name);
            if (player == null)
            {
                return false;
            }
            else
            {
                players.Remove(player);
                return true;
            }
        }
        public Player PromotePlayer(string name)
        {
            var player = players.Find(p => p.Name == name);
            if (player.Rank == "Trial")
            {
                player.Rank = "Member";
            }
            return player;
        }
        public Player DemotePlayer(string name)
        {
            var player = players.Find(p => p.Name == name);
            if (player.Rank == "Member")
            {
                player.Rank = "Trial";
            }
            return player;
        }
        public Player[] KickPlayersByClass(string myClass)
        {
            List<Player> removed = new List<Player>();
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].MyClass == myClass)
                {
                    removed.Add(players[i]);
                    players.Remove(players[i]);
                }
            }
            return removed.ToArray();
        }
        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine($"Players in the guild: {Name}");
            foreach (var player in players)
            {
                report.AppendLine(player.ToString());
            }
            return report.ToString().TrimEnd();
        }
    }
}
