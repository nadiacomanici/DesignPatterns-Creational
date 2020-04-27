namespace AbstractFactory_Cars_End.Classes.Contracts
{
    public interface ICarFactory
    {
        FuelStorage CreateFuelStorage();
        IEngine CreateEngine();
    }
}
