using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PizzaShop
{
    public partial class UserData : Form
    {
        private CustomerAdmin customer = new CustomerAdmin();
        private Customer c;

        public UserData()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxName.Text) || string.IsNullOrWhiteSpace(tbxPhone.Text))
            {
                MessageBox.Show("Please fill the required blanks.");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbxEmail.Text))
                {
                    c = new Customer(tbxName.Text, tbxPhone.Text);
                    customer.AddCustomer(c);
                    this.Hide();
                    OrderForm orderForm = new OrderForm(c);
                    orderForm.Show();
                }
                else
                {
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = regex.Match(tbxEmail.Text);
                    if (match.Success)
                    {
                        c = new Customer(tbxName.Text, tbxPhone.Text, tbxEmail.Text);
                        customer.AddCustomer(c);
                        this.Hide();
                        OrderForm orderForm = new OrderForm(c);
                        orderForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email address.");
                    }
                }
            }
        }

        private void UserData_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }
    }
}
