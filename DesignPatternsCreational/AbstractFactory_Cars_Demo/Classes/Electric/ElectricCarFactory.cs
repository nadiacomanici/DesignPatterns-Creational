namespace AbstractFactory_Cars_Begin.Classes.Electric
{
    public class ElectricCarFactory : ICarFactory
    {
        private double _capacityInUnits;
        private double _availableUnits;
        private string _unit;

        public ElectricCarFactory(double capacityInUnits, double availableUnits, string unit)
        {
            _capacityInUnits = capacityInUnits;
            _availableUnits = availableUnits;
            _unit = unit;
        }

        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new ElectricBattery(_capacityInUnits, _availableUnits, _unit);
        }
    }
}
