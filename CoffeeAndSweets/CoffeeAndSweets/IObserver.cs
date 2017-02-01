using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeAndSweets
{
    public interface IObserver
    {
        void UpdateCoffeeBean(int c);
        void UpdateMilk(int m);
        void UpdateSugar(int s);
        void ShowConsume();
    }
}