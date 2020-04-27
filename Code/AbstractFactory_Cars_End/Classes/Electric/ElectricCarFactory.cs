using AbstractFactory_Cars_End.Classes.Contracts;
using AbstractFactory_Cars_End.Classes.Electric;

namespace AbstractFactory_Cars_End.Classes.Combustion
{
    public class ElectricCarFactory : ICarFactory
    {
        private readonly double _capacityInUnits;
        private readonly double _availableUnits;

        public ElectricCarFactory(double capacityInUnits, double availableUnits)
        {
            _capacityInUnits = capacityInUnits;
            _availableUnits = availableUnits;
        }

        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new ElectricBattery(_capacityInUnits, _availableUnits, "kW");
        }
    }
}
