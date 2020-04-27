using AbstractFactory_Cars_End.Classes.Contracts;
using AbstractFactory_Cars_End.Classes.Electric;

namespace AbstractFactory_Cars_End.Classes.Combustion
{
    public class ElectricCarFactory : ICarFactory
    {
        public Engine CreateEngine()
        {
            return new ElectricEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new ElectricBattery(30, 30, "kW");
        }
    }
}
