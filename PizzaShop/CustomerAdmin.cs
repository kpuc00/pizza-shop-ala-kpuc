﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class CustomerAdmin
    {
        private static List<Customer> customers = new List<Customer>();
        Customer customer = new Customer();

        public CustomerAdmin() { }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public Customer[] GetCustomers()
        {
            return customers.ToArray();
        }

    }
}