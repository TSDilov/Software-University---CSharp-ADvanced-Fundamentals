using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue = 12;
        private int maxValue = 90;
        public override bool IsValid(object obj)
        {
            var ageOfPerson = (int)obj;
            if (ageOfPerson < minValue || ageOfPerson > maxValue)
            {
                return false;
            }
            return true;
        }
    }
}
