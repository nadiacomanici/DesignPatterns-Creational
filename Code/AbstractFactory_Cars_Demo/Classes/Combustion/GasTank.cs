namespace AbstractFactory_Cars_Demo.Classes
{
    public class GasTank : FuelStorage
    {
        public GasTank(double capacityInUnits, double availableUnits) : base(capacityInUnits, availableUnits, "liters")
        {

        }

        protected override double GetUnitsToFillInHalfASecond()
        {
            return 1;
        }
    }
}