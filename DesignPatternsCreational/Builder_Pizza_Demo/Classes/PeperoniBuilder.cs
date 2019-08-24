namespace Builder_Pizza_Demo.Classes
{
    public class PeperoniBuilder : PizzaBuilder
    {
        private Size _size;
        private Crust _crust;

        public PeperoniBuilder(Size size, Crust crust)
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
            _pizza.BaseSauce = BaseSauce.TomatoSauce;
        }

        public override void AddChesses()
        {
            _pizza.Cheeses.Add(Cheese.Mozarella);
        }

        public override void AddCrust()
        {
            _pizza.Crust = _crust;
        }

        public override void AddMeats()
        {
            _pizza.Meats.Add(Meat.Peperoni);
        }

        public override void AddVegetables()
        {
            _pizza.Vegetables.Add(Vegetable.HotPepper);
        }
    }
}
