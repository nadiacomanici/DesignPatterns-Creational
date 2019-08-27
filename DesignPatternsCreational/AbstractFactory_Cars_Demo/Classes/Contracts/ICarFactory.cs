namespace AbstractFactory_Cars_Demo.Classes.Contracts
{
    public interface ICarFactory
    {
        IEngine CreateEngine();
        FuelStorage CreateFuelStorage();
    }
}
