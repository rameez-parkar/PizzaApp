using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    class Cart
    {
        List<Pizza> cartItems = new List<Pizza>();

        public void AddPizza(Pizza pizza)
        {
            cartItems.Add(pizza);
        }

        public void DisplayCartItems()
        {
            Console.WriteLine("\n-----------------Cart Items-----------------");
            foreach(Pizza pizza in cartItems)
            {
                Console.WriteLine("#Pizza ID : " + pizza.pizzaId);
                Console.WriteLine(" Pizza Size : " + pizza.size);
                Console.WriteLine(" Pizza Base : " + pizza.pizzaBase);
                Console.WriteLine(" Pizza Toppings : ");
                foreach(string topping in pizza.toppings)
                {
                    Console.WriteLine("  -"+topping);
                }
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
