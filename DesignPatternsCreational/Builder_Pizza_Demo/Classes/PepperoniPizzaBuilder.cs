namespace Builder_Pizza_Begin.Classes
{
    public class PepperoniPizzaBuilder : PizzaBuilder
    {
        public override void AddCheeses()
        {
            _pizza.Cheeses.Add(Cheese.Mozarella);
        }

        public override void AddMeat()
        {
            _pizza.Meats.Add(Meat.Peperoni);
            _pizza.Meats.Add(Meat.Peperoni);
        }

        public override void AddSauce()
        {
            _pizza.BaseSauce = BaseSauce.TomatoSauce;
        }

        public override void AddVegetables()
        {
            _pizza.Vegetables.Add(Vegetable.HotPepper);
        }

        public override void CreateBaseCrust()
        {
            _pizza.Crust = Crust.Thin;
        }
    }
}
