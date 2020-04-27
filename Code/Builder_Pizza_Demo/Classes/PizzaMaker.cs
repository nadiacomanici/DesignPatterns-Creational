using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pizza_Demo.Classes
{
    public class PizzaMaker
    {
        private readonly PizzaBuilder pizzaBuilder;

        public PizzaMaker(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }

        public Pizza GetPizza()
        {
            return pizzaBuilder.GetPizza();
        }

        public void Build()
        {
            pizzaBuilder.CreatePizza();
            pizzaBuilder.AddCrust();
            pizzaBuilder.AddBaseSauce();
            pizzaBuilder.AddCheeses();
            pizzaBuilder.AddMeat();
            pizzaBuilder.AddVegetables();
        }
    }
}
