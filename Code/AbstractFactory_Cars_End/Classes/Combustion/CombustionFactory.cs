using AbstractFactory_Cars_End.Classes.Contracts;

namespace AbstractFactory_Cars_End.Classes.Combustion
{
    public class CombustionCarFactory : ICarFactory
    {
        public Engine CreateEngine()
        {
            return new CombustionEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new GasTank(30, 30, "liters");
        }
    }
}
