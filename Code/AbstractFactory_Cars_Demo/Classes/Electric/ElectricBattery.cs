namespace AbstractFactory_Cars_Demo.Classes
{
    public class ElectricBattery : FuelStorage
    {
        public ElectricBattery(double capacityInUnits, double availableUnits) : base(capacityInUnits, availableUnits, "kW")
        {

        }

        protected override double GetUnitsToFillInHalfASecond()
        {
            return 0.2;
        }
    }
}