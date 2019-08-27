namespace AbstractFactory_Cars_Begin.Classes
{
    public interface ICarFactory
    {
        IEngine CreateEngine();
        FuelStorage CreateFuelStorage();
    }
}
