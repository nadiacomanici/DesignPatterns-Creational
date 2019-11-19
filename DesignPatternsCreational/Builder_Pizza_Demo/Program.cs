using System;
using Builder_Pizza_Begin.Classes;

namespace Builder_Pizza_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            //var quatroFormaggi = new Pizza(Size.Medium, Crust.Thin, BaseSauce.TomatoBasilSauce);
            //quatroFormaggi.Cheeses.Add(Cheese.Parmezan);
            //quatroFormaggi.Cheeses.Add(Cheese.Mozarella);
            //quatroFormaggi.Cheeses.Add(Cheese.Cheddar);
            //quatroFormaggi.Cheeses.Add(Cheese.Brie);
            //Console.WriteLine(quatroFormaggi.GetOrderedPizza());

            //var peperoniPizza = new Pizza(Size.Medium, Crust.Thick, BaseSauce.TomatoSauce);
            //peperoniPizza.Cheeses.Add(Cheese.Mozarella);
            //peperoniPizza.Meats.Add(Meat.Peperoni);
            //peperoniPizza.Vegetables.Add(Vegetable.HotPepper);
            //Console.WriteLine(peperoniPizza.GetOrderedPizza());

            var pizzaMaker = new PizzaMaker(new QuattroFormaggiPizzaBuilder());
            pizzaMaker.BuildPizza();
            var qFormaggiPizza = pizzaMaker.GetPizza();
            Console.WriteLine(qFormaggiPizza.GetOrderedPizza());

            Console.WriteLine("===============================");

            var pepperoniPizzaMaker = new PizzaMaker(new PepperoniPizzaBuilder());
            pepperoniPizzaMaker.BuildPizza();
            var pepperoniPizza = pepperoniPizzaMaker.GetPizza();
            Console.WriteLine(pepperoniPizza.GetOrderedPizza());
        }
    }
}
