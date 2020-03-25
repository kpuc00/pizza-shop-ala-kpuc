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
    public partial class EditCustomer : Form
    {
        CustomerAdmin admin = new CustomerAdmin();
        Customer customer;
        int indexInList;
        public EditCustomer(Customer givenCustomer, int givenIndex)
        {
            InitializeComponent();
            admin.LoadCustomersFromFile();
            tbxName.Text = givenCustomer.Name;
            tbxPhone.Text = givenCustomer.Phone;
            tbxEmail.Text = givenCustomer.Email;
            customer = givenCustomer;
            indexInList = givenIndex;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbxPhone.Text.Length < 10 || tbxPhone.Text.Length > 15)
            {
                MessageBox.Show("Invalid phone number. Phone must have at least 10 digits and no more than 15 digits.");
            }
            else if (string.IsNullOrWhiteSpace(tbxEmail.Text))
            {
                EditCustomerData();
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(tbxEmail.Text);
                if (match.Success)
                {
                    EditCustomerData();
                }
                else
                {
                    MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to remove this customer from the system? \n\n {admin.Customers.ElementAt<Customer>(indexInList)}", "Remove customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                admin.Customers.RemoveAt(indexInList);
                CloseForm();
            }
        }

        private void EditCustomerData()
        {
            admin.Customers.RemoveAt(indexInList);
            admin.Customers.Insert(indexInList, new Customer(customer.Id, tbxName.Text, tbxPhone.Text, tbxEmail.Text));
            CloseForm();
        }

        private void CloseForm()
        {
            admin.SaveCustomersToFile();
            ChefForm chefForm = new ChefForm();
            this.Hide();
            chefForm.Show();
        }

        private void EditCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChefForm chefForm = new ChefForm();
            this.Hide();
            chefForm.Show();
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
