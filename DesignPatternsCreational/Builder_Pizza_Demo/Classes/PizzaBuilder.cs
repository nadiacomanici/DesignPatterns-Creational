using System;

namespace Builder_Pizza_Begin.Classes
{
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        #region Abstract Methods
        public abstract void CreateBaseCrust();

        public abstract void AddSauce();

        public abstract void AddCheeses();

        public abstract void AddVegetables();

        public abstract void AddMeat();
        #endregion Abstract Methods

        public void CreatePizza()
        {
            _pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}