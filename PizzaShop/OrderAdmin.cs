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
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }


            string fileNameRevenue = "RevenueBAK";
            FileStream fs2 = null;
            BinaryFormatter bf2 = null;
            try
            {
                fs2 = new FileStream(fileNameRevenue, FileMode.Open, FileAccess.Read);
                bf2 = new BinaryFormatter();
                Order.ShopRevenue = (double)bf2.Deserialize(fs2);
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            finally
            {
                if (fs2 != null)
                {
                    fs2.Close();
                }
            }

            string fileNameLastOrderId = "LastOrderIdBAK";
            FileStream fs3 = null;
            BinaryFormatter bf3 = null;
            try
            {
                fs3 = new FileStream(fileNameLastOrderId, FileMode.Open, FileAccess.Read);
                bf3 = new BinaryFormatter();
                Order.IdSeeder = (int)bf3.Deserialize(fs3);
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            finally
            {
                if (fs3 != null)
                {
                    fs3.Close();
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
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            FileStream fs2 = null;
            BinaryFormatter bf2 = null;
            string fileNameRevenue = "RevenueBAK";
            try
            {
                fs2 = new FileStream(fileNameRevenue, FileMode.OpenOrCreate, FileAccess.Write);
                bf2 = new BinaryFormatter();
                bf2.Serialize(fs2, Order.ShopRevenue);
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            finally
            {
                if (fs2 != null)
                {
                    fs2.Close();
                }
            }

            FileStream fs3 = null;
            BinaryFormatter bf3 = null;
            string fileNameLastOrderId = "LastOrderIdBAK";
            try
            {
                fs3 = new FileStream(fileNameLastOrderId, FileMode.OpenOrCreate, FileAccess.Write);
                bf3 = new BinaryFormatter();
                bf3.Serialize(fs3, Order.IdSeeder);
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            finally
            {
                if (fs3 != null)
                {
                    fs3.Close();
                }
            }
        }
    }
}
