using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeAndSweets
{
    public class SweetWrap : IItem
    {
        private int _coffeeBean;
        private int _milk;
        private int _sugar;
        private Sweet _sweet;

        public SweetWrap(Sweet sweet)
        {
            _coffeeBean = 0;
            _milk = 0;
            _sugar = 0;
            _sweet = sweet;
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
                return _sweet.price;
            }

            set
            {
                _sweet.price = value;
            }
        }

        public string title
        {
            get
            {
                return _sweet.title;
            }

            set
            {
                _sweet.title = value;
            }
        }
    }
}