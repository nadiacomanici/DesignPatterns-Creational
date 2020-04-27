using AbstractFactory_OS_Demo.Classes.Contract;
using AbstractFactory_OS_Demo.Classes.Windows;

namespace AbstractFactory_OS_Demo.Classes.Windows
{
    public class WindowsFactory : IPlatformFactory
    {
        private readonly string id;
        private readonly string username;

        public WindowsFactory(string id, string username)
        {
            this.id = id;
            this.username = username;
        }
        public IAccount CreateAccount()
        {
            return new MicrosoftAccount(id, username);
        }

        public IStore CreateStore()
        {
            return new WindowsStore();
        }
    }
}
