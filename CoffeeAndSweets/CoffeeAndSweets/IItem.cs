using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeAndSweets
{
    public interface IItem
    {
        int coffeeBean { get; set; }
        int milk { get; set; }
        double price { get; set; }
        int sugar { get; set; }
        string title { get; set; }
    }
}