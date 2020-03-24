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

        public ChefForm()
        {
            InitializeComponent();
            UpdateCustomersListbox();
        }

        private void UpdateCustomersListbox()
        {
            lbxCustomers.Items.Clear();
            foreach (Customer c in customer.GetCustomers())
            {
                lbxCustomers.Items.Add(c);
            }
        }

        private void ChefForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }
    }
}
