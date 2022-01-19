using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int DefaultDruidPower = 100;

        public Paladin(string name)
            : base(name, DefaultDruidPower)
        {
        }
        public override string CastAbility()
            => base.CastAbility() + $"healed for {Power}";
        public override BaseHero GetHero()
        {
            return new Paladin(this.Name);
        }
    }
}
