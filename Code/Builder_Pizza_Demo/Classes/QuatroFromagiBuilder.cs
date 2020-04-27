using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pizza_Demo.Classes
{
    class QuatroFromagiBuilder : PizzaBuilder
    {
        public QuatroFromagiBuilder(Size size):base(size)
        {

        }
        internal override void AddBaseSauce()
        {
            pizza.BaseSauce = BaseSauce.GarlicSauce;
        }

        internal override void AddCheeses()
        {
            pizza.Cheeses.Add(Cheese.Brie);
            pizza.Cheeses.Add(Cheese.Cheddar);
            pizza.Cheeses.Add(Cheese.Mozarella);
            pizza.Cheeses.Add(Cheese.Parmezan);
        }

        internal override void AddCrust()
        {
            pizza.Crust = Crust.Thin;
        }

        internal override void AddMeat()
        {
            
        }

        internal override void AddVegetables()
        {
            
        }
    }
}
