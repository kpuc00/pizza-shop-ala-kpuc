﻿using System;
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

        private static int idSeeder = 100;
        private static double shopRevenue;
        private double totalPrice;

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

        public string OrderNumber { get; private set; }
        public int CustomerId { get; private set; }
        public string CustomerName { get; private set; }
        public DateTime Timestamp { get; private set; }
        public List<Pizza> Pizzas
        {
            get
            {
                return pizzas;
            }
            set
            {
                pizzas = value;
            }
        }
        public List<Drink> Drinks
        {
            get
            {
                return drinks;
            }
            set
            {
                drinks = value;
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

        public Order(int givenCustomerId, string givenCustomerName, DateTime givenTimestamp, List<Pizza> givenPizzas, List<Drink> givenDrinks, double givenPrice)
        {
            Pizzas = new List<Pizza>();
            Drinks = new List<Drink>();
            OrderNumber = "PS" + idSeeder;
            idSeeder++;
            CustomerId = givenCustomerId;
            CustomerName = givenCustomerName;
            Timestamp = givenTimestamp;
            Pizzas = givenPizzas;
            Drinks = givenDrinks;
            TotalPrice = givenPrice;
        }

        public Order(int givenCustomerId, string givenCustomerName, DateTime givenTimestamp, List<Pizza> givenPizzas, double givenPrice)
        {
            Pizzas = new List<Pizza>();
            OrderNumber = "PS" + idSeeder;
            idSeeder++;
            CustomerId = givenCustomerId;
            CustomerName = givenCustomerName;
            Timestamp = givenTimestamp;
            Pizzas = givenPizzas;
            TotalPrice = givenPrice;
        }

        public Order(int givenCustomerId, string givenCustomerName, DateTime givenTimestamp, List<Drink> givenDrinks, double givenPrice)
        {
            Drinks = new List<Drink>();
            OrderNumber = "PS" + idSeeder;
            idSeeder++;
            CustomerId = givenCustomerId;
            CustomerName = givenCustomerName;
            Timestamp = givenTimestamp;
            Drinks = givenDrinks;
            TotalPrice = givenPrice;
        }

        public string GetOrderNumber()
        {
            return OrderNumber;
        }

        public override string ToString()
        {
            return $"Order: {OrderNumber} - Customer: {CustomerName} - Total: € {TotalPrice} - Date: {Timestamp}";
        }
    }
}
