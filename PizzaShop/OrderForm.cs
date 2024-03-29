﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class OrderForm : Form
    {
        private static List<object> cart = new List<object>();

        private string customerName;
        private int customerId;
        private static double totalPrice;
        private double price;
        private bool orderSent = false;

        CustomerAdmin customer = new CustomerAdmin();
        OrderAdmin order = new OrderAdmin();
        Order o;
        Pizza pizza;
        Drink drink;
        PizzaType pizzaType;
        DateTime dateTime;


        public OrderForm(Customer givenCustomer)
        {
            InitializeComponent();
            customerName = givenCustomer.GetName();
            customerId = givenCustomer.GetId();
            lblTitle.Text = $"Hello {customerName}, let's get started...";
            cbMargherittaCrust.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuattroForCrust.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuattroStaCrust.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPepperoniCrust.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBBQChickenCrust.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateCartListBox();
            order.LoadOrdersFromFile();
        }

        private void UpdateCartListBox()
        {
            lblCartCounter.Text = $"Cart: {cart.Count().ToString()}/30";
            lbxDetails.Items.Clear();
            if (cart.Count() == 0)
            {
                lbxDetails.Items.Add("Empty");
                lbxDetails.Items.Add("");
                lbxDetails.Items.Add($"Total: € {totalPrice}");
            }
            else
            {
                foreach (var p in cart)
                {
                    lbxDetails.Items.Add(p);
                }
                lbxDetails.Items.Add("");
                lbxDetails.Items.Add($"Total: € {totalPrice}");
            }
        }
        private void CheckCartLimit()
        {
            if (cart.Count() >= 30)
            {
                MessageBox.Show("You have reached the cart max limit of products!", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //--------------------------------------------------------------------
        //*****************************PIZZAS*********************************
        //--------------------------------------------------------------------
        private void btnAddMargheritta_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            pizzaType = new PizzaType();
            int amount = Convert.ToInt32(amountMargheritta.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 0;

            if (amount > 0 && cart.Count() < 30)
            {
                switch (cbMargherittaCrust.Text)
                {
                    case "Thin crust":
                        pizzaType = PizzaType.thin;
                        price = (basePrice + addPrice) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Margheritta", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Thick crust":
                        pizzaType = PizzaType.thick;
                        price = (basePrice + addPrice + 0.51) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Margheritta", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Cheese filled crust":
                        pizzaType = PizzaType.filled;
                        price = (basePrice + addPrice + 1.96) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Margheritta", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    default:
                        MessageBox.Show("Please select pizza type!");
                        break;
                }
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select amount of pizza!");
            }
        }
        private void cbMargherittaCrust_TextChanged(object sender, EventArgs e)
        {
            amountMargheritta_ValueChanged(sender, e);
            amountMargheritta.Value = 1;
            amountMargheritta.Enabled = true;
        }
        private void amountMargheritta_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountMargheritta.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 0;

            switch (cbMargherittaCrust.Text)
            {
                case "Thin crust":
                    priceMargheritta.Text = "€ " + ((basePrice + addPrice) * amount).ToString();
                    break;
                case "Thick crust":
                    priceMargheritta.Text = "€ " + ((basePrice + addPrice + 0.51) * amount).ToString();
                    break;
                case "Cheese filled crust":
                    priceMargheritta.Text = "€ " + ((basePrice + addPrice + 1.96) * amount).ToString();
                    break;
                default:
                    if (amountMargheritta.Value != 0)
                    {
                        MessageBox.Show("Please select pizza type!");
                        amountMargheritta.Value = 0;
                    }
                    break;
            }
        }
        //--------------------------------------------------------------------
        private void btnAddQuattroFor_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            pizzaType = new PizzaType();
            int amount = Convert.ToInt32(amountQuattroFor.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 2.00;

            if (amount > 0 && cart.Count() < 30)
            {
                switch (cbQuattroForCrust.Text)
                {
                    case "Thin crust":
                        pizzaType = PizzaType.thin;
                        price = (basePrice + addPrice) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Quattro formaggi", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Thick crust":
                        pizzaType = PizzaType.thick;
                        price = (basePrice + addPrice + 0.51) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Quattro formaggi", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Cheese filled crust":
                        pizzaType = PizzaType.filled;
                        price = (basePrice + addPrice + 1.96) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Quattro formaggi", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    default:
                        MessageBox.Show("Please select pizza type!");
                        break;
                }
            }
            else if(amount <= 0)
            {
                MessageBox.Show("Please select amount of pizza!");
            }
        }
        private void cbQuattroForCrust_TextChanged(object sender, EventArgs e)
        {
            amountQuattroFor_ValueChanged(sender, e);
            amountQuattroFor.Value = 1;
            amountQuattroFor.Enabled = true;
        }
        private void amountQuattroFor_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountQuattroFor.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 2.00;

            switch (cbQuattroForCrust.Text)
            {
                case "Thin crust":
                    priceQuattroFor.Text = "€ " + ((basePrice + addPrice) * amount).ToString();
                    break;
                case "Thick crust":
                    priceQuattroFor.Text = "€ " + ((basePrice + addPrice + 0.51) * amount).ToString();
                    break;
                case "Cheese filled crust":
                    priceQuattroFor.Text = "€ " + ((basePrice + addPrice + 1.96) * amount).ToString();
                    break;
                default:
                    if (amountQuattroFor.Value != 0)
                    {
                        MessageBox.Show("Please select pizza type!");
                        amountQuattroFor.Value = 0;
                    }
                    break;
            }
        }
        //--------------------------------------------------------------------
        private void btnAddQuattroSta_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            //Pizza quattroSta;
            pizzaType = new PizzaType();
            int amount = Convert.ToInt32(amountQuattroSta.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 1.50;

            if (amount > 0 && cart.Count() < 30)
            {
                switch (cbQuattroStaCrust.Text)
                {
                    case "Thin crust":
                        pizzaType = PizzaType.thin;
                        price = (basePrice + addPrice) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Quattro stagioni", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Thick crust":
                        pizzaType = PizzaType.thick;
                        price = (basePrice + addPrice + 0.51) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Quattro stagioni", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Cheese filled crust":
                        pizzaType = PizzaType.filled;
                        price = (basePrice + addPrice + 1.96) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Quattro stagioni", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    default:
                        MessageBox.Show("Please select pizza type!");
                        break;
                }
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select amount of pizza!");
            }
        }
        private void cbQuattroStaCrust_TextChanged(object sender, EventArgs e)
        {
            amountQuattroSta_ValueChanged(sender, e);
            amountQuattroSta.Value = 1;
            amountQuattroSta.Enabled = true;
        }
        private void amountQuattroSta_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountQuattroSta.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 1.50;

            switch (cbQuattroStaCrust.Text)
            {
                case "Thin crust":
                    priceQuattroSta.Text = "€ " + ((basePrice + addPrice) * amount).ToString();
                    break;
                case "Thick crust":
                    priceQuattroSta.Text = "€ " + ((basePrice + addPrice + 0.51) * amount).ToString();
                    break;
                case "Cheese filled crust":
                    priceQuattroSta.Text = "€ " + ((basePrice + addPrice + 1.96) * amount).ToString();
                    break;
                default:
                    if (amountQuattroSta.Value != 0)
                    {
                        MessageBox.Show("Please select pizza type!");
                        amountQuattroSta.Value = 0;
                    }
                    break;
            }
        }
        //--------------------------------------------------------------------
        private void btnAddPepperoni_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            pizzaType = new PizzaType();
            int amount = Convert.ToInt32(amountPepperoni.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 1.00;

            if (amount > 0 && cart.Count() < 30)
            {
                switch (cbPepperoniCrust.Text)
                {
                    case "Thin crust":
                        pizzaType = PizzaType.thin;
                        price = (basePrice + addPrice) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Pepperoni", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Thick crust":
                        pizzaType = PizzaType.thick;
                        price = (basePrice + addPrice + 0.51) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Pepperoni", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Cheese filled crust":
                        pizzaType = PizzaType.filled;
                        price = (basePrice + addPrice + 1.96) * amount;
                        totalPrice += price;
                        pizza = new Pizza("Pepperoni", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    default:
                        MessageBox.Show("Please select pizza type!");
                        break;
                }
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select amount of pizza!");
            }
        }
        private void cbPepperoniCrust_TextChanged(object sender, EventArgs e)
        {
            amountPepperoni_ValueChanged(sender, e);
            amountPepperoni.Value = 1;
            amountPepperoni.Enabled = true;
        }
        private void amountPepperoni_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountPepperoni.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 1.00;

            switch (cbPepperoniCrust.Text)
            {
                case "Thin crust":
                    pricePepperoni.Text = "€ " + ((basePrice + addPrice) * amount).ToString();
                    break;
                case "Thick crust":
                    pricePepperoni.Text = "€ " + ((basePrice + addPrice + 0.51) * amount).ToString();
                    break;
                case "Cheese filled crust":
                    pricePepperoni.Text = "€ " + ((basePrice + addPrice + 1.96) * amount).ToString();
                    break;
                default:
                    if (amountPepperoni.Value != 0)
                    {
                        MessageBox.Show("Please select pizza type!");
                        amountPepperoni.Value = 0;
                    }
                    break;
            }
        }
        //--------------------------------------------------------------------
        private void btnAddBBQChicken_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            pizzaType = new PizzaType();
            int amount = Convert.ToInt32(amountBBQChicken.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 1.00;

            if (amount > 0 && cart.Count() < 30)
            {
                switch (cbBBQChickenCrust.Text)
                {
                    case "Thin crust":
                        pizzaType = PizzaType.thin;
                        price = (basePrice + addPrice) * amount;
                        totalPrice += price;
                        pizza = new Pizza("BBQ Chicken", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Thick crust":
                        pizzaType = PizzaType.thick;
                        price = (basePrice + addPrice + 0.51) * amount;
                        totalPrice += price;
                        pizza = new Pizza("BBQ Chicken", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    case "Cheese filled crust":
                        pizzaType = PizzaType.filled;
                        price = (basePrice + addPrice + 1.96) * amount;
                        totalPrice += price;
                        pizza = new Pizza("BBQ Chicken", pizzaType, amount, price);
                        cart.Add(pizza);
                        UpdateCartListBox();
                        break;
                    default:
                        MessageBox.Show("Please select pizza type!");
                        break;
                }
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select amount of pizza!");
            }
        }
        private void cbBBQChickenCrust_TextChanged(object sender, EventArgs e)
        {
            amountBBQChicken_ValueChanged(sender, e);
            amountBBQChicken.Value = 1;
            amountBBQChicken.Enabled = true;
        }
        private void amountBBQChicken_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountBBQChicken.Value);
            Pizza pizzaPrice = new Pizza();
            double basePrice = pizzaPrice.GetBasePrice();
            double addPrice = 1.00;

            switch (cbBBQChickenCrust.Text)
            {
                case "Thin crust":
                    priceBBQChicken.Text = "€ " + ((basePrice + addPrice) * amount).ToString();
                    break;
                case "Thick crust":
                    priceBBQChicken.Text = "€ " + ((basePrice + addPrice + 0.51) * amount).ToString();
                    break;
                case "Cheese filled crust":
                    priceBBQChicken.Text = "€ " + ((basePrice + addPrice + 1.96) * amount).ToString();
                    break;
                default:
                    if (amountBBQChicken.Value != 0)
                    {
                        MessageBox.Show("Please select pizza type!");
                        amountBBQChicken.Value = 0;
                    }
                    break;
            }
        }
        //--------------------------------------------------------------------
        //*****************************DRINKS*********************************
        //--------------------------------------------------------------------
        private void btnAddFlatWater_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            int amount = Convert.ToInt32(amountFlatWater.Value);
            price = 2.50 * amount;
            totalPrice += price;
            if (amount > 0 && cart.Count() < 30)
            {
                drink = new Drink("Flat water", amount, price);
                cart.Add(drink);
                UpdateCartListBox();
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select amount of drink!");
            }
        }
        private void amountFlatWater_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountFlatWater.Value);

            price = 2.50 * amount;
            if (amount > 0)
            {
                priceFlatWater.Text = "€ " + price;
            }
        }
        //--------------------------------------------------------------------
        private void btnAddSparklingWater_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            int amount = Convert.ToInt32(amountSparklingWater.Value);
            price = 2.50 * amount;
            totalPrice += price;
            if (amount > 0 && cart.Count() < 30)
            {
                drink = new Drink("Sparkling water", amount, price);
                cart.Add(drink);
                UpdateCartListBox();
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select amount of drink!");
            }
        }
        private void amountSparklingWater_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountSparklingWater.Value);
            price = 2.50 * amount;
            if (amount > 0)
            {
                priceSparklingWater.Text = "€ " + price;
            }
        }
        //--------------------------------------------------------------------
        private void btnAddCola_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            int amount = Convert.ToInt32(amountCola.Value);
            price = 2.75 * amount;
            totalPrice += price;
            if (amount > 0 && cart.Count() < 30)
            {
                drink = new Drink("Cola", amount, price);
                cart.Add(drink);
                UpdateCartListBox();
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select amount of drink!");
            }
        }
        private void amountCola_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountCola.Value);
            price = 2.75 * amount;
            if (amount > 0)
            {
                priceCola.Text = "€ " + price;
            }
        }
        //--------------------------------------------------------------------
        private void btnAddIceTea_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            int amount = Convert.ToInt32(amountIceTea.Value);
            price = 2.75 * amount;
            totalPrice += price;
            if (amount > 0 && cart.Count() < 30)
            {
                drink = new Drink("Ice tea", amount, price);
                cart.Add(drink);
                UpdateCartListBox();
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select amount of drink!");
            }
        }
        private void amountIceTea_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountIceTea.Value);
            price = 2.75 * amount;
            if (amount > 0)
            {
                priceIceTea.Text = "€ " + price;
            }
        }
        //--------------------------------------------------------------------
        private void btnAddEnergyDrink_Click(object sender, EventArgs e)
        {
            CheckCartLimit();
            int amount = Convert.ToInt32(amountEnergyDrink.Value);
            price = 3.75 * amount;
            totalPrice += price;
            if (amount > 0 && cart.Count() < 30)
            {
                drink = new Drink("Energy drink", amount, price);
                cart.Add(drink);
                UpdateCartListBox();
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select amount of drink!");
            }
        }
        private void amountEnergyDrink_ValueChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountEnergyDrink.Value);
            price = 3.75 * amount;
            if (amount > 0)
            {
                priceEnergyDrink.Text = "€ " + price;
            }
        }
        //--------------------------------------------------------------------

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            if (cart.Count == 0)
            {
                MessageBox.Show("You shopping cart is empty. Please select products!", "Empty cart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var cartDetails = string.Join(Environment.NewLine, cart);
                DialogResult dialogResult = MessageBox.Show($"Order details: \n\n {cartDetails} \n Total: € {totalPrice} \n\n Do you want to continue?", "Order Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    o = new Order(customerId, customerName, dateTime, cart, totalPrice);
                    order.AddOrder(o);
                    orderSent = true;
                    SaveData();
                    DialogResult dialogResult2 = MessageBox.Show($"Thank you {customerName} for visiting our shop! \n Your order number is {o.GetOrderNumber()}. \n\n Do you want a receipt?", "Order placed", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        ShowReceipt(o);
                    }
                    else
                    {
                        CloseForm();
                    }
                }
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            price = 0;
            cart.Clear();
            UpdateCartListBox();
        }

        private void RemoveTemporaryData()
        {
            customerName = null;
            customerId = 0;
            totalPrice = 0;
            price = 0;
            cart.Clear();
            UpdateCartListBox();
        }

        private void ShowReceipt(Order order)
        {
            this.Hide();
            ReceiptForm receipt = new ReceiptForm(order);
            RemoveTemporaryData();
            receipt.Show();
        }

        private void SaveData()
        {
            customer.SaveCustomersToFile();
            order.SaveOrdersToFile();
        }

        private void CloseForm()
        {
            RemoveTemporaryData();
            this.Hide();
            orderSent = false;
            PizzaShopHome pizzaShopHome = new PizzaShopHome();
            pizzaShopHome.Show();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (orderSent == false)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the window? Your order is not sent!", "Cancel order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    CloseForm();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                CloseForm();
            }
        }

    }
}
