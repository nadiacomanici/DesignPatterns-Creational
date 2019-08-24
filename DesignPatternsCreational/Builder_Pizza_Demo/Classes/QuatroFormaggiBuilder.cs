namespace Builder_Pizza_Demo.Classes
{
    public class QuatroFormaggiBuilder : PizzaBuilder
    {
        private Size _size;
        private Crust _crust;

        public QuatroFormaggiBuilder(Size size, Crust crust)
        {
            _size = size;
            _crust = crust;
        }

        public override void SetSize()
        {
            _pizza.Size = _size;
        }

        public override void AddBaseSauce()
        {
            _pizza.BaseSauce = BaseSauce.TomatoBasilSauce;
        }

        public override void AddChesses()
        {
            _pizza.Cheeses.Add(Cheese.Brie);
            _pizza.Cheeses.Add(Cheese.Cheddar);
            _pizza.Cheeses.Add(Cheese.Mozarella);
            _pizza.Cheeses.Add(Cheese.Parmezan);
        }

        public override void AddCrust()
        {
            _pizza.Crust = _crust;
        }

        public override void AddMeats()
        {
            _pizza.Meats.Clear();
        }

        public override void AddVegetables()
        {
            _pizza.Vegetables.Clear();
        }
    }
}
