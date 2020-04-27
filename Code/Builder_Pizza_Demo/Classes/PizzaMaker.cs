using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pizza_Begin.Classes
{
    public class PizzaMaker
    {
        private readonly PizzaBuilder _pizzaBuilder;

        public PizzaMaker(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void BuildPizza()
        {
            _pizzaBuilder.CreatePizza();
            _pizzaBuilder.CreateBaseCrust();
            _pizzaBuilder.AddSauce();
            _pizzaBuilder.AddCheeses();
            _pizzaBuilder.AddVegetables();
            _pizzaBuilder.AddMeat();
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.GetPizza();
        }
    }
}
