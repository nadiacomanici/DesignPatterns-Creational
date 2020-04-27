using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pizza_Demo.Classes
{
    public class PepperoniBuilder : PizzaBuilder
    {
        public PepperoniBuilder(Size size) : base(size)
        {

        }
        internal override void AddBaseSauce()
        {
            pizza.BaseSauce = BaseSauce.TomatoBasilSauce;
        }

        internal override void AddCheeses()
        {
            pizza.Cheeses.Add(Cheese.Mozarella);
        }

        internal override void AddCrust()
        {
            pizza.Crust = Crust.Thick;
        }

        internal override void AddMeat()
        {
            pizza.Meats.Add(Meat.Peperoni);
        }

        internal override void AddVegetables()
        {
            pizza.Vegetables.Add(Vegetable.HotPepper);
        }
    }
}
