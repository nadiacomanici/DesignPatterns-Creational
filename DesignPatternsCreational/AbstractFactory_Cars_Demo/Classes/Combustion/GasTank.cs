using AbstractFactory_Cars_Demo.Classes.Contracts;

namespace AbstractFactory_Cars_Demo.Classes.Combustion
{
    public class GasTank : FuelStorage
    {
        public GasTank(double capacityInUnits, double availableUnits, string unit) 
            : base(capacityInUnits, availableUnits, unit)
        {
        }

        protected override double GetUnitsToFillInHalfASecond()
        {
            return 1;
        }
    }
}