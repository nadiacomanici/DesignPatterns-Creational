namespace AbstractFactory_Cars_Demo.Classes
{
    public interface ICarFactory
    {
        Engine CreateEngine();
        FuelStorage CreateFuelStorage();
    }
}
