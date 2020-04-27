using AbstractFactory_Cars_End.Classes.Contracts;

namespace AbstractFactory_Cars_End.Classes.Combustion
{
    public class CombustionCarFactory : ICarFactory
    {
        private readonly double _capacityInUnits;
        private readonly double _availableUnits;
        private readonly string _unitName;

        public CombustionCarFactory(double capacityInUnits, double availableUnits, string unitName)
        {
            _capacityInUnits = capacityInUnits;
            _availableUnits = availableUnits;
            _unitName = unitName;
        }

        public IEngine CreateEngine()
        {
            return new CombustionEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new GasTank(_capacityInUnits, _availableUnits, _unitName);
        }
    }
}
