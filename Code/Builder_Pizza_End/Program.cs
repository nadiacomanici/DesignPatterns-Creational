using System;
using Builder_Pizza_End.Classes;

namespace Builder_Pizza_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaMaker = new PizzaMaker(new QuatroFormaggiPizzaBuilder(Crust.Thin, Size.Medium));
            pizzaMaker.BuildPizza();
            Console.WriteLine(pizzaMaker.GetPizza().GetRecipe());

            var pizzaMakerPeperoni = new PizzaMaker(new PeperoniPizzaBuilder(Crust.Thick, Size.Medium));
            pizzaMakerPeperoni.BuildPizza();
            Console.WriteLine(pizzaMakerPeperoni.GetPizza().GetRecipe());
        }
    }
}
