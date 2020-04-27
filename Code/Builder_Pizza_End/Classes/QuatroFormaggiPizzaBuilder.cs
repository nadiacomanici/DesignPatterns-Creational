namespace Builder_Pizza_End.Classes
{
    public class QuatroFormaggiPizzaBuilder : PizzaBuilder
    {
        private Crust _crust;
        private Size _size;

        public QuatroFormaggiPizzaBuilder(Crust crust, Size size)
        {
            _crust = crust;
            _size = size;
        }

        public override void AddBaseSauce()
        {
            _pizza.BaseSauce = BaseSauce.TomatoBasilSauce;
        }

        public override void AddCheeses()
        {
            _pizza.Cheeses.Add(Cheese.Parmezan);
            _pizza.Cheeses.Add(Cheese.Mozarella);
            _pizza.Cheeses.Add(Cheese.Cheddar);
            _pizza.Cheeses.Add(Cheese.Brie);
        }

        public override void AddMeats()
        {
            _pizza.Meats.Clear();
        }

        public override void AddVegetables()
        {
            _pizza.Vegetables.Clear();
        }

        public override void AddCrust()
        {
            _pizza.Crust = _crust;
            _pizza.Size = _size;
        }
    }
}
