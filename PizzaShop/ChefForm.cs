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
            LoadCustomers();
            LoadOrders();
        }

        private void LoadCustomers()
        {
            customer.LoadCustomersFromFile();
            UpdateCustomersListbox();
        }

        private void LoadOrders()
        {
            order.LoadOrdersFromFile();
            UpdateOrdersListbox();
        }

        private void UpdateCustomersListbox()
        {
            lblNrCustomers.Text = customer.Customers.Count().ToString();
            lbxCustomers.Items.Clear();
            if (customer.Customers.Count() == 0)
            {
                Customer.IdSeeder = 100;
                lbxCustomers.Items.Add("There are not registered customers in the system.");
            }
            else
            {
                foreach (Customer c in customer.GetCustomers())
                {
                    lbxCustomers.Items.Add(c);
                }
                lbxCustomers.Items.Add("");
                lbxCustomers.Items.Add("Double click on a customer to edit it.");
            }
        }

        private void UpdateOrdersListbox()
        {
            lblNrOrders.Text = order.Orders.Count().ToString();
            lblRevenue.Text = $"€ {Order.ShopRevenue.ToString()}";

            lbxSortedOrders.Items.Clear();
            lbxOrders.Items.Clear();
            if (order.Orders.Count() == 0)
            {
                Order.IdSeeder = 100;
                lbxOrders.Items.Add("There are no orders in the system.");
                lbxSortedOrders.Items.Add("There are no orders in the system.");
            }
            else
            {
                foreach (Order o in order.GetOrders())
                {
                    lbxOrders.Items.Add(o);
                }
                lbxOrders.Items.Add("");
                lbxOrders.Items.Add("Double click on an order to remove it.");

                List<Order> sortedList = order.Orders.OrderByDescending(o => o.TotalPrice).ToList();
                lbxSortedOrders.Items.Add("Sorted orders by price:");
                lbxSortedOrders.Items.Add("");
                foreach (Order sl in sortedList)
                {
                    lbxSortedOrders.Items.Add(sl);
                }
            }
        }

        private void lbxOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbxOrders.IndexFromPoint(e.Location);
            if ((index != System.Windows.Forms.ListBox.NoMatches) && index < order.Orders.Count())
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to remove this order from the system? \n\n {order.Orders.ElementAt<Order>(index)}", "Remove order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    order.Orders.RemoveAt(index);
                    UpdateOrdersListbox();
                }
                order.SaveOrdersToFile();
            }
        }

        private void lbxCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbxCustomers.IndexFromPoint(e.Location);
            if ((index != System.Windows.Forms.ListBox.NoMatches) && index < customer.Customers.Count())
            {
                EditCustomer edit = new EditCustomer(customer.Customers.ElementAt<Customer>(index), index);
                this.Hide();
                edit.Show();
            }
        }

        private void btnResetRevenue_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? This cannot be undone!", "Reset revenue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult==DialogResult.Yes)
            {
                Order.ShopRevenue = 0;
                order.Orders.Clear();
                order.SaveOrdersToFile();
                UpdateOrdersListbox();
            }
            UpdateOrdersListbox();
        }

        private void ChefForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            customer.SaveCustomersToFile();
            order.SaveOrdersToFile();
            this.Hide();
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }
    }
}
