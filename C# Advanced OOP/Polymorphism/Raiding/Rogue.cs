using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        private const int DefaultDruidPower = 80;

        public Rogue(string name)
            : base(name, DefaultDruidPower)
        {
        }
        public override string CastAbility()
            => base.CastAbility() + $"hit for {Power} damage";
      
        public override BaseHero GetHero()
        {
            return new Rogue(this.Name);
        }
    }
}
