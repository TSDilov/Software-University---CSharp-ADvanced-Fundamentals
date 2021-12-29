using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        
        
        public string RandomString()
        {
            var index = new Random().Next(0, Count);
            var removed = this[index];
            RemoveAt(index);
            return removed;
        }
        
    }
}
