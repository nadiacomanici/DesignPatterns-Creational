namespace AbstractFactory_Cars_Demo.Classes.Contracts
{
    public class CombustionCarFactory : ICarFactory
    {
        private double _capacityInUnits;
        private double _availableUnits;

        public CombustionCarFactory(double capacityInUnits, double availableUnits)
        {
            _availableUnits = availableUnits;
            _capacityInUnits = capacityInUnits;
        }

        public Engine CreateEngine()
        {
            return new CombustionEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new GasTank(_capacityInUnits, _availableUnits);
        }
    }
}
