using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeAndSweets
{
    public class Sweet
    {
        private double _price;
        private string _title;

        public Sweet(double p, string t)
        {
            _price = p;
            _title = t;
        }

        public double price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public string title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }
    }
}