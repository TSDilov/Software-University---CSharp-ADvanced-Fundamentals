﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class RaceMotorcycle : Motorcycle
    {
        private const double defaultFuelConsumption = 8;
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }
        public override double FuelConsumption => defaultFuelConsumption;
    }
}
