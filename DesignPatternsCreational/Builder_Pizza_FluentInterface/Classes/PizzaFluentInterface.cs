namespace Builder_Pizza_FluentInterface.Classes
{
    public class PizzaFluentInterface
    {
        protected Pizza _pizza = new Pizza();

        public void CreatePizza()
        {
            _pizza = new Pizza();
        }

        public PizzaFluentInterface WithCrust(Crust crust)
        {
            _pizza.Crust = crust;
            return this;
        }

        public PizzaFluentInterface WithSize(Size size)
        {
            _pizza.Size = size;
            return this;
        }

        public PizzaFluentInterface WithBaseSauce(BaseSauce baseSauce)
        {
            _pizza.BaseSauce = baseSauce;
            return this;
        }

        public PizzaFluentInterface AddCheese(Cheese cheese)
        {
            _pizza.Cheeses.Add(cheese);
            return this;
        }

        public PizzaFluentInterface AddVegetable(Vegetable vegetable)
        {
            _pizza.Vegetables.Add(vegetable);
            return this;
        }

        public PizzaFluentInterface AddMeat(Meat meat)
        {
            _pizza.Meats.Add(meat);
            return this;
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
