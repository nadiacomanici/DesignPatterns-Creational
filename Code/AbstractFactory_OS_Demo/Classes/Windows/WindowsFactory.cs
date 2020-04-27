using AbstractFactory_OS_Demo.Classes.Contracts;

namespace AbstractFactory_OS_Demo.Classes.Windows
{
    public class WindowsFactory : IManufacturerFactory
    {
        private readonly string _id;
        private readonly string _username;

        public WindowsFactory(string id, string username)
        {
            _id = id;
            _username = username;
        }
        public IAppStore CreateAppStore()
        {
            return new WindowsStore();
        }

        public IUser CreateUser()
        {
            return new MicrosoftAccount(_id, _username);
        }
    }
}
