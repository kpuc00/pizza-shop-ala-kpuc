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
    public partial class SecurityKeyForm : Form
    {
        public SecurityKeyForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxKey.Text))
            {
                MessageBox.Show("Please enter the security key!", "Security key", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (tbxKey.Text != "administrator")
                {
                    MessageBox.Show("Wrong security key!", "Security key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    ChefForm chefForm = new ChefForm();
                    chefForm.Show();
                }
            }
        }

        private void SecurityKeyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }

        private void tbxKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }
    }
}
