namespace AbstractFactory_OS_End.Classes.Contracts
{
    public interface IManufacturerFactory
    {
        IUser CreateUser(string userId, string username);

        IAppStore CreateAppStore();
    }
}
