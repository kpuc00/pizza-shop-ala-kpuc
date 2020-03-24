using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
