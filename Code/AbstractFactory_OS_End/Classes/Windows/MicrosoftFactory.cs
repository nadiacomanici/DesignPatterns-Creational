using AbstractFactory_OS_End.Classes.Contracts;

namespace AbstractFactory_OS_End.Classes.Windows
{
    public class MicrosoftFactory : IManufacturerFactory
    {
        public IAppStore CreateAppStore()
        {
            return new WindowsStore();
        }

        public IUser CreateUser(string userId, string username)
        {
            return new MicrosoftAccount(userId, username);
        }
    }
}
