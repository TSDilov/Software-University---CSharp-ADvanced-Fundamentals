using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.PrivatesUnderCommand = new List<Private>();
        }
        public List<Private> PrivatesUnderCommand { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var _private in PrivatesUnderCommand)
            {
                sb.AppendLine(" " + _private);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
