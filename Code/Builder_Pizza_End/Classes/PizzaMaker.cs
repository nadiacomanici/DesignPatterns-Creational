namespace Builder_Pizza_End.Classes
{
    public class PizzaMaker
    {
        private PizzaBuilder _pizzaBuilder;

        public PizzaMaker(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.GetPizza();
        }

        public void BuildPizza()
        {
            _pizzaBuilder.CreatePizza();
            _pizzaBuilder.AddCrust();
            _pizzaBuilder.AddBaseSauce();
            _pizzaBuilder.AddCheeses();
            _pizzaBuilder.AddVegetables();
            _pizzaBuilder.AddMeats();
        }
    }
}
