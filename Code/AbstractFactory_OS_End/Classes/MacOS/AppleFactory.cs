using AbstractFactory_OS_End.Classes.Contracts;

namespace AbstractFactory_OS_End.Classes.MacOS
{
    public class AppleFactory : IManufacturerFactory
    {
        private readonly string _userId;
        private readonly string _username;

        public AppleFactory(string userId, string username)
        {
            _userId = userId;
            _username = username;
        }

        public IAppStore CreateAppStore()
        {
            return new AppleStore();
        }

        public IUserAccount CreateUser()
        {
            return new AppleUser(_userId, _username);
        }
    }
}
