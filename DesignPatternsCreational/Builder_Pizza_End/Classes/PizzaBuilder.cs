namespace Builder_Pizza_End.Classes
{
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        public void CreatePizza()
        {
            _pizza = new Pizza();
        }

        public abstract void AddCrust();
        public abstract void AddBaseSauce();
        public abstract void AddCheeses();
        public abstract void AddVegetables();
        public abstract void AddMeats();

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
