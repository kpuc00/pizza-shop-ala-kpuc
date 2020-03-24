using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    [Serializable]
    public class Customer
    {
        private static int idSeeder = 0;
        private int id;
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public Customer() {}
        public Customer(string givenName, string givenPhone)
        {
            id = idSeeder;
            idSeeder++;
            Name = givenName;
            Phone = givenPhone;
        }
        public Customer(string givenName, string givenPhone, string givenEmail)
        {
            id = idSeeder;
            idSeeder++;
            Name = givenName;
            Phone = givenPhone;
            Email = givenEmail;
        }
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return Name;
        }
        public override string ToString()
        {
            return $"{id} Name: {Name}, Contact: {Phone} {Email}";
        }
    }
}
