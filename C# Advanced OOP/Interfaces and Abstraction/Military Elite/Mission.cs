using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission
    {
        private string state;
        public Mission(string state, string codeName)
        {
            this.State = state;
            this.CodeName = codeName;
        }
        public string CodeName { get; set; }
        public string State 
        {
            get => this.state;
            set
            {
                if (value != "Finished" && value != "inProgress")
                {
                    throw new ArgumentException("Invalid mission state");
                }
                this.state = value;
            }
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
