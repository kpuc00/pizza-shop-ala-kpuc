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
        OrderAdmin order = new OrderAdmin();

        public OrderNumberForm()
        {
            InitializeComponent();
            order.LoadOrdersFromFile();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNumber.Text))
            {
                MessageBox.Show("Please enter your order number!", "Order info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!(order.Orders.Exists(x => x.OrderNumber == tbxNumber.Text)))
            {
                MessageBox.Show($"Order {tbxNumber.Text} does not exist!", "Order info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"{order.GetOrderByNumber(tbxNumber.Text)}", $"Order info - {tbxNumber.Text}",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (dialogResult==DialogResult.OK)
                {
                    CloseForm();
                }
            }
        }

        private void tbxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }

        private void CloseForm()
        {
            this.Hide();
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }

        private void OrderNumberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }


    }
}
