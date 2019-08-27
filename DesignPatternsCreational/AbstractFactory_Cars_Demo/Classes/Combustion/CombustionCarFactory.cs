using System;

namespace AbstractFactory_Cars_Begin.Classes
{
    public class CombustionCarFactory : ICarFactory
    {
        private double _capacityInUnits;
        private double _availableUnits;
        private string _unit;

        public CombustionCarFactory(double capacityInUnits, double availableUnits, string unit)
        {
            _capacityInUnits = capacityInUnits;
            _availableUnits = availableUnits;
            _unit = unit;
        }

        public IEngine CreateEngine()
        {
            return new CombustionEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new GasTank(_capacityInUnits, _availableUnits, _unit);
        }
    }
}
