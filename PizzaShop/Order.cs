using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    [Serializable]
    public class Order

    {
        private List<Pizza> pizzas = new List<Pizza>();
        private List<Drink> drinks = new List<Drink>();
        private List<object> cart = new List<object>();

        private static int idSeeder = 100;
        private static double shopRevenue;
        private double totalPrice;
        private string orderNumber;

        public static double ShopRevenue
        {
            get
            {
                return shopRevenue;
            }
            set
            {
                shopRevenue = value;
            }
        }
        public static int IdSeeder
        {
            get
            {
                return idSeeder;
            }
            set
            {
                idSeeder = value;
            }
        }

        public string OrderNumber
        {
            get
            {
                return orderNumber;
            }
            private set
            {
                orderNumber = value;
            }
        }
        public int CustomerId { get; private set; }
        public string CustomerName { get; private set; }
        public DateTime Timestamp { get; private set; }

        public List<object> Cart
        {
            get
            {
                return cart;
            }
            set
            {
                cart = value;
            }
        }
        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
                shopRevenue += value;
            }
        }

        public Order(int givenCustomerId, string givenCustomerName, DateTime givenTimestamp, List<object> givenCart, double givenPrice)
        {
            OrderNumber = "PS" + idSeeder;
            idSeeder++;
            CustomerId = givenCustomerId;
            CustomerName = givenCustomerName;
            Timestamp = givenTimestamp;
            Cart = givenCart;
            TotalPrice = givenPrice;
        }

        public string GetOrderNumber()
        {
            return OrderNumber;
        }

        public override string ToString()
        {
            return $"Order: {OrderNumber} - CustomerID: {CustomerId} - Customer name: {CustomerName} - Total: € {TotalPrice} - Date: {Timestamp}";
        }
    }
}
