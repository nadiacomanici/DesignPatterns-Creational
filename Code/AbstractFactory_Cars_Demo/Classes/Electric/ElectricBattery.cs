using AbstractFactory_Cars_Demo.Classes.Contracts;

namespace AbstractFactory_Cars_Demo.Classes.Electric
{
    public class ElectricBattery : FuelStorage
    {
        public ElectricBattery(double capacityInUnits, double availableUnits, string unit) 
            : base(capacityInUnits, availableUnits, unit)
        {
        }

        protected override double GetUnitsToFillInHalfASecond()
        {
            return 0.2;
        }
    }
}
