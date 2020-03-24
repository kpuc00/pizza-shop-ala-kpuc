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
    public partial class PizzaShopHome : Form
    {
        public PizzaShopHome()
        {
            InitializeComponent();
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserData userData = new UserData();
            userData.Show();
        }

        private void btnOrderInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderNumberForm orderNumberForm = new OrderNumberForm();
            orderNumberForm.Show();
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecurityKeyForm securityKeyForm = new SecurityKeyForm();
            securityKeyForm.Show();
        }

        private void PizzaShopHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
