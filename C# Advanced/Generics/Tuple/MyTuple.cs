using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class MyTuple<Item1, Item2>
    {
        public MyTuple(Item1 firstItem, Item2 secondItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
        }
        public Item1 FirstItem { get; set; }
        public Item2 SecondItem { get; set; }
        public string GetItem()
        {
            return $"{FirstItem} -> {SecondItem}";
        }

    }
}
