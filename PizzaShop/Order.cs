using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class Order
    {
        private static int idSeeder = 100;

        public string OrderNumber { get; private set; }
        public int CustomerId { get; private set; }
        public DateTime Timestamp { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Drink> Drinks { get; private set; }
        public double Price { get; private set; }

        public Order(int givenCustomerId, DateTime givenTimestamp, List<Pizza> givenPizzas, List<Drink> givenDrinks, double givenPrice)
        {
            OrderNumber = "PS" + idSeeder;
            idSeeder++;
            CustomerId = givenCustomerId;
            Timestamp = givenTimestamp;
            Pizzas = givenPizzas;
            Drinks = givenDrinks;
            Price = givenPrice;
        }
        public Order(int givenCustomerId, DateTime givenTimestamp, List<Pizza> givenPizzas, double givenPrice)
        {
            OrderNumber = "PS" + idSeeder;
            idSeeder++;
            CustomerId = givenCustomerId;
            Timestamp = givenTimestamp;
            Pizzas = givenPizzas;
            Price = givenPrice;
        }
        public Order(int givenCustomerId, DateTime givenTimestamp, List<Drink> givenDrinks, double givenPrice)
        {
            OrderNumber = "PS" + idSeeder;
            idSeeder++;
            CustomerId = givenCustomerId;
            Timestamp = givenTimestamp;
            Drinks = givenDrinks;
            Price = givenPrice;
        }
        public double GetPrice()
        {
            return Price;
        }
        public string GetOrderNumber()
        {
            return OrderNumber;
        }
        public override string ToString()
        {
            return $"Order no:{OrderNumber} - Customer ID:{CustomerId} - Date: {Timestamp}";
        }
    }
}
