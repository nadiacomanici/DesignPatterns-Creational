using System;
using Builder_Pizza_Demo.Classes;

namespace Builder_Pizza_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var quatroFormaggi = new PizzaMaker(new QuatroFromagiBuilder(Size.Medium));
            quatroFormaggi.Build();
            Console.WriteLine(quatroFormaggi.GetPizza().GetOrderedPizza());

            var pepperoni = new PizzaMaker(new PepperoniBuilder(Size.Large));
            pepperoni.Build();
            Console.WriteLine(pepperoni.GetPizza().GetOrderedPizza());

        }
    }
}
