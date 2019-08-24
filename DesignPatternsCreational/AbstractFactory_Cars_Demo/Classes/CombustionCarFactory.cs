namespace AbstractFactory_Cars_Demo.Classes
{
    public class CombustionCarFactory : ICarFactory
    {
        public Engine CreateEngine()
        {
            return new CombustionEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new GasTank(10, 8, "liters");
        }
    }
}
