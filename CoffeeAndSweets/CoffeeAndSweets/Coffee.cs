using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeAndSweets
{
    public class Coffee : IItem
    {
        private int _coffeeBean;
        private int _milk;
        private int _sugar;
        private double _price;
        private string _title;

        public Coffee(int c, int m, int s, double p, string t)
        {
            _coffeeBean = c;
            _milk = m;
            _sugar = s;
            _price = p;
            _title = t;
        }

        public int coffeeBean
        {
            get
            {
                return _coffeeBean;
            }

            set
            {
                _coffeeBean = value;
            }
        }

        public int milk
        {
            get
            {
                return _milk;
            }

            set
            {
                _milk = value;
            }
        }

        public int sugar
        {
            get
            {
                return _sugar;
            }

            set
            {
                _sugar = value;
            }
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