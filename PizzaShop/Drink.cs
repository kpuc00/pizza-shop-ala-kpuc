using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class Drink
    {
        public string DrinkName { get; private set; }
        public int Amount { get; private set; }
        public double Price { get; private set; }
        public Drink(string givenDrinkName, int givenAmount, double givenPrice)
        {
            DrinkName = givenDrinkName;
            Amount = givenAmount;
            Price = givenPrice;
        }
        public Drink() { }
        public double GetPrice()
        {
            return Price;
        }
        public override string ToString()
        {
            return $"{Amount}x {DrinkName} - € {Price}";
        }
    }
}
