using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pizza_Demo.Classes
{
    public class PizzaMaker
    {
        private PizzaBuilder _pizzaBuilder;

        public PizzaMaker(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void BuildPizza()
        {
            _pizzaBuilder.CreatePizza();
            _pizzaBuilder.SetSize();
            _pizzaBuilder.AddCrust();
            _pizzaBuilder.AddBaseSauce();
            _pizzaBuilder.AddChesses();
            _pizzaBuilder.AddVegetables();
            _pizzaBuilder.AddMeats();
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.GetPizza();
        }
    }
}
