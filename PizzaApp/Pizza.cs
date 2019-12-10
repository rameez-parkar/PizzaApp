using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class Pizza
    {
        public int pizzaId { get; set; }
        public PizzaBase pizzaBase { get; set; }
        public Size size { get; set; }
        public Topping[] toppings { get; set; }
        MenuOptions menuOptions = new MenuOptions();

        public Pizza(int pizzaId)
        {
            this.pizzaId = pizzaId;
        }

        public void CustomizePizza()
        {
            pizzaBase = SetPizzaBase();

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            size = SetPizzaSize();

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            toppings = SetPizzaToppings();

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }

        private PizzaBase SetPizzaBase()
        {
            Console.WriteLine("Choose Pizza Base (Enter Base Number) : ");
            foreach (PizzaBase pBase in menuOptions.pizzaBases)
            {
                Console.WriteLine(pBase.id + " - "+pBase.name+" - Rs. "+pBase.price);
            }
            int baseNumber = int.Parse(Console.ReadLine());
            PizzaBase selectedBase = menuOptions.pizzaBases.Find(pBase => pBase.id.Equals(baseNumber));
            return selectedBase;
        }

        private Size SetPizzaSize()
        {
            Console.WriteLine("Choose Pizza Size (Enter Size as S, M or L) : ");
            foreach (Size pSize in menuOptions.sizes)
            {
                Console.WriteLine(pSize.id + " - " + pSize.size + " - Rs. " + pSize.price);
            }
            char sizeValue = char.Parse(Console.ReadLine());
            Size selectedSize = menuOptions.sizes.Find(pSize => pSize.id.Equals(sizeValue));
            return selectedSize;
        }

        private Topping[] SetPizzaToppings()
        {
            Console.WriteLine("Choose Toppings (Enter Toppings as 0,5,6 ) : ");
            foreach (Topping pTopping in menuOptions.toppings)
            {
                Console.WriteLine(pTopping.id + " - " + pTopping.name + " - Rs. " + pTopping.price);
            }
            string[] toppingsValues = Console.ReadLine().Split(",");
            Topping[] toppings = new Topping[toppingsValues.Length];
            int index = 0;
            foreach (string toppingsValue in toppingsValues)
            {
                toppings[index] = menuOptions.toppings.Find(pTopping => pTopping.id.Equals(int.Parse(toppingsValue)));
                index++;
            }
            return toppings;
        }
    }
}
