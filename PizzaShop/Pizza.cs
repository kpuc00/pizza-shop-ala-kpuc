using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    [Serializable]
    public class Pizza
    {
        private static double basePrice = 5.99;
        public string PizzaName { get; private set; }
        public PizzaType PizzaType { get; private set; }
        public int Amount { get; private set; }
        public double Price { get; private set; }
        public Pizza(string givenPizzaName, PizzaType givenPizzaType, int givenAmount, double givenPrice)
        {
            PizzaName = givenPizzaName;
            PizzaType = givenPizzaType;
            Amount = givenAmount;
            Price = givenPrice;
        }
        public Pizza() { }
        public double GetBasePrice()
        {
            return basePrice;
        }
        public override string ToString()
        {
            return $"{Amount}x {PizzaName} ({PizzaType}) - € {Price}";
        }
    }

}
