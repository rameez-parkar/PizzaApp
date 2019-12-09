using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    class Pizza
    {
        string pizzaBase;
        string size;
        string[] toppings;

        public void CustomizePizza()
        {
            pizzaBase = SetPizzaBase();
            Console.WriteLine("You chose : " + pizzaBase);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            size = SetPizzaSize();
            Console.WriteLine("You chose : " + size);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            toppings = SetPizzaToppings();
            Console.WriteLine("You chose : ");
            foreach (string topping in toppings)
            {
                Console.WriteLine(topping);
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            Console.ReadKey();
        }

        private string SetPizzaBase()
        {
            Console.WriteLine("Choose Pizza Base (Enter Base Number) : ");
            foreach (PizzaBase pBase in Enum.GetValues(typeof(PizzaBase)))
            {
                Console.Write((int)pBase + " - ");
                Console.WriteLine(pBase);
            }
            int baseNumber = int.Parse(Console.ReadLine());
            string pizzaBase = Enum.GetName(typeof(PizzaBase), baseNumber);
            return pizzaBase;
        }

        private string SetPizzaSize()
        {
            Console.WriteLine("Choose Pizza Size (Enter Size as S, M or L) : ");
            foreach (Size pSize in Enum.GetValues(typeof(Size)))
            {
                Console.Write((char)pSize + " - ");
                Console.WriteLine(pSize);
            }
            char sizeValue = char.Parse(Console.ReadLine());
            string size = Enum.GetName(typeof(Size), sizeValue);
            return size;
        }

        private string[] SetPizzaToppings()
        {
            Console.WriteLine("Choose Toppings (Enter Toppings as 0,5,6 ) : ");
            foreach (Topping pTopping in Enum.GetValues(typeof(Topping)))
            {
                Console.Write((int)pTopping + " - ");
                Console.WriteLine(pTopping);
            }
            string[] toppingsValues = Console.ReadLine().Split(",");
            string[] toppings = new string[toppingsValues.Length];
            int index = 0;
            foreach (string toppingsValue in toppingsValues)
            {
                toppings[index] = Enum.GetName(typeof(Topping), int.Parse(toppingsValue));
                index++;
            }
            return toppings;
        }
    }
}
