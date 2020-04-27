using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pizza_Demo.Classes
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;
        private readonly Size size;

        public PizzaBuilder(Size size)
        {
            this.size = size;
        }

        internal Pizza GetPizza()
        {
            return pizza;
        }

        internal void CreatePizza()
        {
            pizza = new Pizza(size);
        }

        internal abstract void AddCrust();

        internal abstract void AddBaseSauce();


        internal abstract void AddCheeses();


        internal abstract void AddVegetables();


        internal abstract void AddMeat();

    }
}
