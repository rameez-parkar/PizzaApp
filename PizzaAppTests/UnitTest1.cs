using PizzaApp;
using System;
using Xunit;
using Newtonsoft.Json;

namespace PizzaAppTests
{
    public class PizzaTests
    {
        [Fact]
        public void Should_Return_Small_Size_Object_When_Size_S_Is_Provided()
        {
            Pizza pizza = new Pizza(101);
            Size expectedSize = new Size() { id='S', size="Small", price=230 };
            Size actualSize = pizza.SetPizzaSize('S');
            Assert.Equal(JsonConvert.SerializeObject(expectedSize), JsonConvert.SerializeObject(actualSize));
        }

        [Fact]
        public void Should_Return_Medium_Size_Object_When_Size_M_Is_Provided()
        {
            Pizza pizza = new Pizza(102);
            Size expectedSize = new Size() { id = 'M', size = "Medium", price = 350 };
            Size actualSize = pizza.SetPizzaSize('M');
            Assert.Equal(JsonConvert.SerializeObject(expectedSize), JsonConvert.SerializeObject(actualSize));
        }

        [Fact]
        public void Should_Return_Large_Size_Object_When_Size_L_Is_Provided()
        {
            Pizza pizza = new Pizza(103);
            Size expectedSize = new Size() { id = 'L', size = "Large", price = 500 };
            Size actualSize = pizza.SetPizzaSize('L');
            Assert.Equal(JsonConvert.SerializeObject(expectedSize), JsonConvert.SerializeObject(actualSize));
        }

        [Fact]
        public void Should_Return_HandTossed_Base_Object_When_BaseNumber_1_Is_Provided()
        {
            Pizza pizza = new Pizza(103);
            PizzaBase expected = new PizzaBase() { id = 1, name = "Hand Tossed", price = 0 };
            PizzaBase actual = pizza.SetPizzaBase(1);
            Assert.Equal(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        [Fact]
        public void Should_Return_PanPizza_Base_Object_When_BaseNumber_4_Is_Provided()
        {
            Pizza pizza = new Pizza(106);
            PizzaBase expected = new PizzaBase() { id = 4, name = "Pan Pizza", price = 40 };
            PizzaBase actual = pizza.SetPizzaBase(4);
            Assert.Equal(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        [Fact]
        public void Should_Return_ThinCrust_Base_Object_When_BaseNumber_2_Is_Provided()
        {
            Pizza pizza = new Pizza(105);
            PizzaBase expected = new PizzaBase() { id = 2, name = "Thin Crust", price = 20 };
            PizzaBase actual = pizza.SetPizzaBase(2);
            Assert.Equal(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        [Fact]
        public void Should_Return_CheeseBurst_Base_Object_When_BaseNumber_3_Is_Provided()
        {
            Pizza pizza = new Pizza(103);
            PizzaBase expected = new PizzaBase() { id = 3, name = "Cheese Burst", price = 80 };
            PizzaBase actual = pizza.SetPizzaBase(3);
            Assert.Equal(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        [Fact]
        public void Should_Return_Selected_Toppings_Object_When_String_Of_Toppings_Id_Is_Provided()
        {
            Pizza pizza = new Pizza(110);
            Topping[] expected = new Topping[3];
            expected[0] = new Topping() { id=1, name="Jalepino",price=20};
            expected[1] = new Topping() { id = 10, name = "Chicken Tikka", price = 60 };
            expected[2] = new Topping() { id = 6, name = "Olives", price = 30 };
            Topping[] actual = pizza.SetPizzaToppings("1,10,6");
            Assert.Equal(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        [Fact]
        public void Should_Give_Total_Price_For_All_Cart_Items()
        {
            Pizza pizza1 = new Pizza(120);
            Pizza pizza2 = new Pizza(121);
            Cart cart = new Cart();

            pizza1.size = pizza1.SetPizzaSize('M');
            pizza1.pizzaBase = pizza1.SetPizzaBase(2);
            pizza1.toppings = pizza1.SetPizzaToppings("1,10,6");
            cart.AddPizza(pizza1);

            pizza2.size = pizza2.SetPizzaSize('L');
            pizza2.pizzaBase = pizza2.SetPizzaBase(3);
            pizza2.toppings = pizza2.SetPizzaToppings("1,2,5,6,9");
            cart.AddPizza(pizza2);
            cart.DisplayCartItems();
            double actual = cart.totalPrice;
            double expected = 1260;

            Assert.Equal(expected, actual);
        }
    }
}
