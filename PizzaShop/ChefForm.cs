using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class ChefForm : Form
    {
        CustomerAdmin customer = new CustomerAdmin();
        OrderAdmin order = new OrderAdmin();

        public ChefForm()
        {
            InitializeComponent();
            UpdateCustomersListbox();
            UpdateOrdersListbox();
        }

        private void UpdateCustomersListbox()
        {
            customer.LoadCustomersFromFile();
            lbxCustomers.Items.Clear();
            foreach (Customer c in customer.GetCustomers())
            {
                lbxCustomers.Items.Add(c);
            }
        }

        private void UpdateOrdersListbox()
        {
            order.LoadOrdersFromFile();
            lbxOrders.Items.Clear();
            foreach (Order o in order.GetOrders())
            {
                lbxOrders.Items.Add(o);
            }
        }

        private void ChefForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customer.SaveCustomersToFile();
            order.SaveOrdersToFile();
            this.Hide();
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }
    }
}
