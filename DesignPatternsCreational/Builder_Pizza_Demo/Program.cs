using System;
using Builder_Pizza_Demo.Classes;

namespace Builder_Pizza_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaQFMaker = new PizzaMaker(new QuatroFormaggiBuilder(Size.Medium, Crust.Thin));
            pizzaQFMaker.BuildPizza();
            Console.WriteLine(pizzaQFMaker.GetPizza().GetOrderedPizza());

            var pizzaPeperoniMaker = new PizzaMaker(new PeperoniBuilder(Size.Medium, Crust.Thick));
            pizzaPeperoniMaker.BuildPizza();
            Console.WriteLine(pizzaPeperoniMaker.GetPizza().GetOrderedPizza());
        }
    }
}
