﻿using System;
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
            customer.LoadCustomersFromFile();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxName.Text) || string.IsNullOrWhiteSpace(tbxPhone.Text))
            {
                MessageBox.Show("Please fill the required blanks.", "User data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbxName.Text.Length > 40)
            {
                MessageBox.Show("The name must be less than 40 characters.", "User data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbxPhone.Text.Length < 10 || tbxPhone.Text.Length > 15)
            {
                MessageBox.Show("Invalid phone number. Phone must have at least 10 digits and no more than 15 digits.", "User data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("Invalid email address.", "User data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }

        private void tbxPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }

        private void tbxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }
    }
}
