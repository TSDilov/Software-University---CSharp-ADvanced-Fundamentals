using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static int GetDifferenceOfDates(string firstDateAsString, string secondDateAsString) 
        {
            var firstDate = DateTime.Parse(firstDateAsString);
            var secondDate = DateTime.Parse(secondDateAsString);
            int difference = (firstDate - secondDate).Days;
            if (difference > 0)
            {
                return (firstDate - secondDate).Days;
            }
            if (difference < 0)
            {
                return (secondDate - firstDate).Days;
            }
            return 0;
        }
    }
}
