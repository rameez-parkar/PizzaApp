using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class Cart
    {
        List<Pizza> cartItems = new List<Pizza>();
        public double totalPrice { get; set; } = 0;

        public void AddPizza(Pizza pizza)
        {
            cartItems.Add(pizza);
        }

        public void DisplayCartItems()
        {
            Console.WriteLine("\n-----------------CART ITEMS-----------------");
            foreach(Pizza pizza in cartItems)
            {
                double pizzaPrice = 0;
                Console.WriteLine("#Pizza ID : " + pizza.pizzaId);
                Console.WriteLine(" Pizza Size : " + pizza.size.size);
                pizzaPrice += pizza.size.price;
                Console.WriteLine(" Pizza Base : " + pizza.pizzaBase.name);
                pizzaPrice += pizza.pizzaBase.price;
                Console.WriteLine(" Pizza Toppings : ");
                foreach(Topping topping in pizza.toppings)
                {
                    Console.WriteLine("  -"+topping.name);
                    pizzaPrice += topping.price;
                }
                Console.WriteLine(" Cost of Pizza "+pizza.pizzaId+" = Rs. "+pizzaPrice);
                totalPrice += pizzaPrice;
                Console.WriteLine("--------------------------------------------");
            }

            Console.WriteLine("FINAL AMOUNT : Rs. " + totalPrice);
        }
    }
}
