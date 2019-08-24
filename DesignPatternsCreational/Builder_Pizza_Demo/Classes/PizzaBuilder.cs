using System;

namespace Builder_Pizza_Demo.Classes
{
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        public void CreatePizza()
        {
            _pizza = new Pizza();
        }

        public abstract void SetSize();
        public abstract void AddCrust();
        public abstract void AddBaseSauce();
        public abstract void AddChesses();
        public abstract void AddVegetables();
        public abstract void AddMeats();

        internal Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
