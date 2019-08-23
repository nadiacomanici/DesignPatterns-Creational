namespace Builder_Pizza_End.Classes
{
    public class PeperoniPizzaBuilder : PizzaBuilder
    {
        private Crust _crust;
        private Size _size;

        public PeperoniPizzaBuilder(Crust crust, Size size)
        {
            _crust = crust;
            _size = size;
        }

        public override void AddBaseSauce()
        {
            _pizza.BaseSauce = BaseSauce.TomatoSauce;
        }

        public override void AddCheeses()
        {
            _pizza.Cheeses.Add(Cheese.Mozarella);
        }

        public override void AddMeats()
        {
            _pizza.Meats.Add(Meat.Peperoni);
        }

        public override void AddVegetables()
        {
            _pizza.Vegetables.Add(Vegetable.HotPepper);
        }

        public override void AddCrust()
        {
            _pizza.Crust = _crust;
            _pizza.Size = _size;
        }
    }
}
