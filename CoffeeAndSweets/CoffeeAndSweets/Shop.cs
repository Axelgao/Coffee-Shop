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
    public partial class Shop : Form, IObserver
    {
        private ISubject _subject;
        private List<IItem> _orderList;
        private string orderPrice;
        private string orderName;
        private double totalPrice;
        private double totalOrder;
        private double totalValue;
        private double coffeeBeanStock;
        private double milkStock;
        private double sugarStock;
        private double coffeeBeanUsed;
        private double milkUsed;
        private double sugarUsed;
        private double coffeeBeanUsedPercentage;
        private double milkUsedPercentage;
        private double sugarUsedPercentage;
        private IItem i;


        public Shop(ISubject s)
        {
            InitializeComponent();
            _subject = s;
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            lblItemName.Text = "";
            lblItemPrice.Text = "";
            lblTotalPrice.Text = "";
            totalPrice = 0;
            coffeeBeanStock = 500;
            milkStock = 500;
            sugarStock = 500;
            _orderList = new List<IItem>();
        }

        private void btnFlatWhite_Click(object sender, EventArgs e)
        {
            i = new Coffee(15, 20, 15, 4.25, "Flat White");
            AddItem();
            ShowConsume();
        }

        public void UpdateCoffeeBean(int c)
        {
            coffeeBeanStock += c;
        }

        public void UpdateMilk(int m)
        {
            milkStock += m;
        }

        public void UpdateSugar(int s)
        {
            sugarStock += s;
        }

        public void AddOrderList(IItem i)
        {
            _orderList.Add(i);
        }

        public void Done()
        {
            if (totalPrice == 0)
            {
                MessageBox.Show("Select an item first", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totalValue += totalPrice;
                lblTotalValue.Text = "Total Value: " + Convert.ToString(totalValue);
                totalOrder += 1;
                lblTotalOrders.Text = "Total Orders: " + Convert.ToString(totalOrder);
                lblItemName.Text = "";
                lblItemPrice.Text = "";
                lblTotalPrice.Text = "";
                totalPrice = 0;
                _orderList = new List<IItem>();
            }
        }

        public void DisplayOrderInfo()
        {
            orderPrice = "";
            orderName = "";
            totalPrice = 0;
            foreach (IItem i in _orderList)
            {
                orderPrice += Convert.ToString(i.price) + Environment.NewLine;
                orderName += i.title + Environment.NewLine;
                totalPrice += i.price;
            }
            lblTotalPrice.Text = "Total Price: " + Convert.ToString(totalPrice);
            lblItemName.Text = orderName;
            lblItemPrice.Text = orderPrice;
        }

        public List<IItem> orderList
        {
            get
            {
                return _orderList;
            }
        }

        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            i = new Coffee(20, 15, 15, 4.5, "Cappuccino");
            AddItem();
            ShowConsume();
        }

        private void btnMochaccino_Click(object sender, EventArgs e)
        {
            i = new Coffee(20, 15, 20, 4.75, "Mochaccino");
            AddItem();
            ShowConsume();
        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            i = new Coffee(25, 10, 10, 5, "Espresso");
            AddItem();
            ShowConsume();
        }

        private void btnGelato_Click(object sender, EventArgs e)
        {
            i = new SweetWrap(new Sweet(6.5, "Gelato"));
            AddItem();
            ShowConsume();
        }

        private void btnSundae_Click(object sender, EventArgs e)
        {
            i = new SweetWrap(new Sweet(5.5, "Sundae"));
            AddItem();
            ShowConsume();
        }

        private void btnCheeseCake_Click(object sender, EventArgs e)
        {
            i = new SweetWrap(new Sweet(10, "Cheese Cake"));
            AddItem();
            ShowConsume();
        }

        private void btnCookie_Click(object sender, EventArgs e)
        {
            i = new SweetWrap(new Sweet(3, "Cookie"));
            AddItem();
            ShowConsume();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Done();
        }

        private void btnReplenishment_Click(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            _subject.RemoveObserver(this);
        }

        public void ShowConsume()
        {
            coffeeBeanUsedPercentage = coffeeBeanUsed / coffeeBeanStock;
            milkUsedPercentage = milkUsed / milkStock;
            sugarUsedPercentage = sugarUsed / sugarStock;
            if (coffeeBeanUsedPercentage > 1)
            {
                MessageBox.Show("Coffee bean is not enough", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (milkUsedPercentage > 1)
            {
                MessageBox.Show("Milk is not enough", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sugarUsedPercentage > 1)
            {
                MessageBox.Show("Sugar is not enough", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblCoffeeBeanConsume.Text = "Coffee Bean Consume: " + Math.Ceiling(coffeeBeanUsedPercentage * 100).ToString() + "%";
                lblMilkConsume.Text = "Milk Consume: " + Math.Ceiling(milkUsedPercentage * 100).ToString() + "%";
                lblSugarConsume.Text = "Sugar Consume: " + Math.Ceiling(sugarUsedPercentage * 100).ToString() + "%";
            }
        }

        public void AddItem()
        {
            AddOrderList(i);
            DisplayOrderInfo();
            coffeeBeanUsed += i.coffeeBean;
            milkUsed += i.milk;
            sugarUsed += i.sugar;
        }
    }
}
