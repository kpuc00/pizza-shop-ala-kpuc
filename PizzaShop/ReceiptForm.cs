using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class ReceiptForm : Form
    {
        private List<object> cart = new List<object>();

        private double totalPrice;
        private string customerName;
        private string orderNumber;
        private DateTime dateTime;
        private string receipt;
        public ReceiptForm(Order order)
        {
            InitializeComponent();
            cart = order.Cart;
            totalPrice = order.TotalPrice;
            customerName = order.CustomerName;
            orderNumber = order.GetOrderNumber();
            dateTime = order.Timestamp;
            PrintReceipt();
        }
        private void PrintReceipt()
        {
            receipt = $"\r\n" +
                            $"Pizza Shop a la Kpuc" +
                            $"\r\n\r\n" +
                            $"---------------------------------------------------------------------" +
                            $"\r\n" +
                            $"Order number: {orderNumber}" +
                            $"\r\n\r\n";
            foreach (var p in cart)
            {
                receipt += p + "\r\n";
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

        private void btnSaveReceipt_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                string filename;
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Title = "Save receipt";
                ofd.FileName = $"Receipt-Order{orderNumber}-{dateTime.ToString("ddMMyyyy_HHmmss")}";
                ofd.DefaultExt = "txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    fs = new FileStream(filename, FileMode.Create, FileAccess.Write);

                    sw = new StreamWriter(fs);
                    sw.WriteLine(receipt);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    fs.Close();
                    CloseReceipt();
                }
            }
        }

        private void CloseReceipt()
        {
            this.Hide();
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }

        private void ReceiptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseReceipt();
        }

    }
}
