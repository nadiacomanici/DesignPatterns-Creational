namespace AbstractFactory_OS_End.Classes.Contracts
{
    public interface IManufacturerFactory
    {
        IUserAccount CreateUser();

        IAppStore CreateAppStore();
    }
}
