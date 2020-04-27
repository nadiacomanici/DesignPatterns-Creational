namespace AbstractFactory_Cars_Demo.Classes.Contracts
{
    public class ElectricCarFactory : ICarFactory
    {
        private double _capacityInUnits;
        private double _availableUnits;

        public ElectricCarFactory(double capacityInUnits, double availableUnits)
        {
            _availableUnits = availableUnits;
            _capacityInUnits = capacityInUnits;
        }
        public Engine CreateEngine()
        {
            return new ElectricEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new ElectricBattery(_capacityInUnits, _availableUnits);
        }
    }
}
