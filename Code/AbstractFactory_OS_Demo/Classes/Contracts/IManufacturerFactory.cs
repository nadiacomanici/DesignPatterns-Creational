namespace AbstractFactory_OS_Demo.Classes.Contracts
{
    public interface IManufacturerFactory
    {
        IAppStore CreateAppStore();
        IUser CreateUser();
    }
}
