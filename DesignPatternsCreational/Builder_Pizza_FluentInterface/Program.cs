using System;
using Builder_Pizza_FluentInterface.Classes;

namespace Builder_Pizza_FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var quatroFormaggiPizza = new PizzaFluentInterface()
                .WithCrust(Crust.Thin)
                .WithSize(Size.Medium)
                .WithBaseSauce(BaseSauce.TomatoBasilSauce)
                .AddCheese(Cheese.Parmezan)
                .AddCheese(Cheese.Mozarella)
                .AddCheese(Cheese.Cheddar)
                .AddCheese(Cheese.Brie);
            Console.WriteLine(quatroFormaggiPizza.GetPizza().GetRecipe());

            var pizzaMakerPeperoni = new PizzaFluentInterface()
                .WithCrust(Crust.Thick)
                .WithSize(Size.Medium)
                .WithBaseSauce(BaseSauce.TomatoSauce)
                .AddCheese(Cheese.Mozarella)
                .AddMeat(Meat.Peperoni)
                .AddVegetable(Vegetable.HotPepper);
            Console.WriteLine(pizzaMakerPeperoni.GetPizza().GetRecipe());
        }
    }
}
