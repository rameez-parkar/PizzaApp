using System;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####### PIZZA APP #######");
            Console.WriteLine("\nHow many pizzas would you like to order?");
            int total = int.Parse(Console.ReadLine());
            if (total < 2)
            {
                Console.WriteLine("You must order 2 or more pizzas...");
            }
            else
            {
                Cart cart = new Cart();
                for (int count = 0; count < total; count++)
                {
                    Console.WriteLine("\nCustomize Pizza "+(count+1));
                    Console.WriteLine("----------------------------");
                    Pizza pizza = new Pizza(count+100);
                    pizza.CustomizePizza();
                    cart.AddPizza(pizza);
                }
                cart.DisplayCartItems();

                Console.WriteLine("\nProceed To Order? (y/n)");
                char proceedToOrder = char.Parse(Console.ReadLine());
                if (proceedToOrder == 'y')
                {
                    Random random = new Random();
                    int orderId = random.Next(1, 1000);
                    Booking booking = new Booking(orderId, cart);
                    booking.ConfirmBooking();
                    Console.WriteLine("Order Placed! Press any button to exit...");
                }
                else
                {
                    Console.WriteLine("Order Cancelled! Press any button to exit...");
                }
            }
            Console.ReadKey();
        }
    }
}
