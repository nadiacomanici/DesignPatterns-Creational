using AbstractFactory_OS_End.Classes.Contracts;

namespace AbstractFactory_OS_End.Classes.MacOS
{
    public class AppleFactory : IManufacturerFactory
    {
        public IAppStore CreateAppStore()
        {
            return new AppleStore();
        }

        public IUser CreateUser(string userId, string username)
        {
            return new AppleUser(userId, username);
        }
    }
}
