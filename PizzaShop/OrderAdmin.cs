using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace PizzaShop
{
    public class OrderAdmin
    {
        private static List<Order> orders = new List<Order>();
        public List<Order> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
            }
        }

        public OrderAdmin() { }
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public Order[] GetOrders()
        {
            return orders.ToArray();
        }
        public void LoadOrdersFromFile()
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
                throw new Exception(ex.Message);
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
        public void SaveOrdersToFile()
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
                throw new Exception(ex.Message);
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
