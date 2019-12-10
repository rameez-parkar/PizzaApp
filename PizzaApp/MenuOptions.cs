using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class MenuOptions
    {
        public List<Size> sizes = new List<Size>()
        {
            new Size(){id='S', size="Small", price=230},
            new Size(){id='M', size="Medium", price=350},
            new Size(){id='L', size="Large", price=500}
        };

        public List<PizzaBase> pizzaBases = new List<PizzaBase>()
        {
            new PizzaBase(){id=1, name="Hand Tossed", price=0},
            new PizzaBase(){id=2, name="Thin Crust", price=20},
            new PizzaBase(){id=3, name="Cheese Burst", price=80},
            new PizzaBase(){id=4, name="Pan Pizza", price=40},
        };

        public List<Topping> toppings = new List<Topping>()
        {
            new Topping(){id=1, name="Jalepino", price=20},
            new Topping(){id=2, name="Paprica", price=30},
            new Topping(){id=3, name="Corn", price=40},
            new Topping(){id=4, name="Capsicum", price=20},
            new Topping(){id=5, name="Paneer", price=40},
            new Topping(){id=6, name="Olives", price=30},
            new Topping(){id=7, name="Mushroom", price=30},
            new Topping(){id=8, name="BBQ Chicken", price=70},
            new Topping(){id=9, name="Chicken Sausage", price=80},
            new Topping(){id=10, name="Chicken Tikka", price=60},
        };
    }
}
