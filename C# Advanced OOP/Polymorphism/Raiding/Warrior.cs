using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int DefaultDruidPower = 100;

        public Warrior(string name)
            : base(name, DefaultDruidPower)
        {
        }
        public override string CastAbility()
            => base.CastAbility() + $"hit for {Power} damage";

        public override BaseHero GetHero()
        {
            return new Warrior(this.Name);
        }
    }
}
