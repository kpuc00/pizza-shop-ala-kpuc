using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class PizzaShopHome : Form
    {
        public PizzaShopHome()
        {
            InitializeComponent();
            LoadCustomersFromFile();
            LoadOrdersFromFile();
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

        public void LoadCustomersFromFile()
        {
            CustomerAdmin customer = new CustomerAdmin();
            customer.Customers.Clear();
            string fileNameCustomers = "CustomersBAK";
            FileStream fs = null; 
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(fileNameCustomers, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                customer.Customers = (List<Customer>)bf.Deserialize(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
        private void LoadOrdersFromFile()
        {
            OrderAdmin order = new OrderAdmin();
            order.Orders.Clear();
            string fileNameOrders = "OrdersBAK";
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(fileNameOrders, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                order.Orders = (List<Order>)bf.Deserialize(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        public void SaveCustomersToFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            CustomerAdmin customer = new CustomerAdmin();
            string fileNameCustomers = "CustomersBAK";
            try
            {
                fs = new FileStream(fileNameCustomers, FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, customer.Customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }            
        }
        private void SaveOrdersToFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            OrderAdmin order = new OrderAdmin();
            string fileNameOrders = "OrdersBAK";
            try
            {
                fs = new FileStream(fileNameOrders, FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, order.Orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void PizzaShopHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveCustomersToFile();
            SaveOrdersToFile();
            Environment.Exit(0);
        }
    }
}
