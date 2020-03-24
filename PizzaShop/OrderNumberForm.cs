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
    public partial class OrderNumberForm : Form
    {
        public OrderNumberForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNumber.Text))
            {
                MessageBox.Show("Please enter your order number!");
            }
            else
            {
                MessageBox.Show(tbxNumber.Text);
            }
        }

        private void OrderNumberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }
    }
}
