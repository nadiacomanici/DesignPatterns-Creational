using AbstractFactory_OS_Demo.Classes.Contracts;

namespace AbstractFactory_OS_Demo.Classes.MacOS
{
    public class AppleFactory : IManufacturerFactory
    {
        private readonly string _id;
        private readonly string _username;

        public AppleFactory(string id, string username)
        {
            _id = id;
            _username = username;
        }
        public IAppStore CreateAppStore()
        {
            return new AppleStore();
        }

        public IUser CreateUser()
        {
            return new AppleUser(_id, _username);
        }
    }
}
