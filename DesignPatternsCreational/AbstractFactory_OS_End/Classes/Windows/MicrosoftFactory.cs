using AbstractFactory_OS_End.Classes.Contracts;

namespace AbstractFactory_OS_End.Classes.Windows
{
    public class MicrosoftFactory : IManufacturerFactory
    {
        private readonly string _userId;
        private readonly string _username;

        public MicrosoftFactory(string userId, string username)
        {
            _userId = userId;
            _username = username;
        }

        public IAppStore CreateAppStore()
        {
            return new WindowsStore();
        }

        public IUserAccount CreateUser()
        {
            return new MicrosoftAccount(_userId, _username);
        }
    }
}
