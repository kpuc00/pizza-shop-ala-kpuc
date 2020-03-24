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
    public partial class ReceiptForm : Form
    {
        private List<Pizza> pizzas = new List<Pizza>();
        private List<Drink> drinks = new List<Drink>();
        private double totalPrice;
        private string customerName;
        private string orderNumber;
        private DateTime dateTime;
        public ReceiptForm(Order order)
        {
            InitializeComponent();
            pizzas = order.Pizzas;
            drinks = order.Drinks;
            totalPrice = order.TotalPrice;
            customerName = order.CustomerName;
            orderNumber = order.GetOrderNumber();
            dateTime = order.Timestamp;
            PrintReceipt();
        }
        private void PrintReceipt()
        {
            string receipt = $"\r\n" +
                            $"Pizza Shop a la Kpuc" +
                            $"\r\n\r\n" +
                            $"---------------------------------------------------------------------" +
                            $"\r\n" +
                            $"Order number: {orderNumber}" +
                            $"\r\n\r\n";
            foreach (var p in pizzas)
            {
                receipt += p + "\r\n";
            }
            receipt += $"\r\n";
            foreach (var d in drinks)
            {
                receipt += d + "\r\n";
            }
            receipt += $"\r\n" +
             $"---------------------------------------------------------------------" +
             $"\r\n" +
             $"TOTAL                                                        € {totalPrice}" +
             $"\r\n" +
             $"---------------------------------------------------------------------" +
             $"\r\n" +
             $"Ordered by {customerName} on {dateTime}" +
             $"\r\n" +
             $"Bon Appetit!";
            tbxReceipt.Text = receipt;
        }

        private void ReceiptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }
    }
}
