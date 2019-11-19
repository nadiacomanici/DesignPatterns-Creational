namespace Builder_Pizza_Begin.Classes
{
    public class QuattroFormaggiPizzaBuilder : PizzaBuilder
    {
        public override void AddCheeses()
        {
            _pizza.Cheeses.Add(Cheese.Brie);
            _pizza.Cheeses.Add(Cheese.Cheddar);
            _pizza.Cheeses.Add(Cheese.Mozarella);
            _pizza.Cheeses.Add(Cheese.Parmezan);
        }

        public override void AddMeat()
        {
        }

        public override void AddSauce()
        {
            _pizza.BaseSauce = BaseSauce.TomatoBasilSauce;
        }

        public override void AddVegetables()
        {
        }

        public override void CreateBaseCrust()
        {
            _pizza.Crust = Crust.Thin;
        }
    }
}
