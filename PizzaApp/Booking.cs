using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class Booking
    {
        public int orderId { get; set; }
        public Cart cart { get; set; }

        public Booking(int orderId, Cart cart)
        {
            this.orderId = orderId;
            this.cart = cart;
        }

        public void ConfirmBooking()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Order Successful!");
            Console.WriteLine("ORDER ID : "+orderId);
            Console.WriteLine("FINAL AMOUNT : "+cart.totalPrice);
            Console.WriteLine("--------------------------------------------");
        }
    }
}
