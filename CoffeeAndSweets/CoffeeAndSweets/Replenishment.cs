using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeAndSweets
{
    public partial class Replenishment : Form, ISubject
    {
        private int _coffeeBean = 500;
        private int _milk = 500;
        private int _sugar = 500;
        private List<IObserver> _observers = new List<IObserver>();

        public Replenishment()
        {
            InitializeComponent();

            Shop s = new Shop(this);
            s.Show();
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

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out _coffeeBean);
            foreach (IObserver o in _observers)
            {
                o.UpdateCoffeeBean(coffeeBean);
                o.ShowConsume();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out _milk);
            foreach (IObserver o in _observers)
            {
                o.UpdateMilk(milk);
                o.ShowConsume();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out _sugar);
            foreach (IObserver o in _observers)
            {
                o.UpdateSugar(sugar);
                o.ShowConsume();
            }
        }
    }
}
