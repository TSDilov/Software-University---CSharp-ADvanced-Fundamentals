using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        public string Name
        {
            get => this.name;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value; 
            }
        }
        public double Stats => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
        public int Endurance 
        { 
            get => this.endurance;
            private set
            {
                ValidateStat(nameof(this.Endurance),value);
                this.endurance = value;
            }
        }

        public int Sprint 
        { 
            get => this.sprint;
            private set
            {
                ValidateStat(nameof(this.Sprint), value);
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                ValidateStat(nameof(this.Dribble), value);
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                ValidateStat(nameof(this.Passing), value);
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                ValidateStat(nameof(this.Shooting), value);
                this.shooting = value;
            }
        }
        private void ValidateStat(string name, int value)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{name} should be between 0 and 100.");
            }
        }
    }
}
