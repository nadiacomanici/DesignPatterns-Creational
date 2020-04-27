using AbstractFactory_OS_Demo.Classes.Apple;
using AbstractFactory_OS_Demo.Classes.Contract;
using AbstractFactory_OS_Demo.Classes.Windows;

namespace AbstractFactory_OS_Demo.Classes.Apple
{
    public class AppleFactory : IPlatformFactory
    {
        private readonly string id;
        private readonly string username;

        public AppleFactory(string id, string username)
        {
            this.id = id;
            this.username = username;
        }
        public IAccount CreateAccount()
        {
            return new AppleAccount(id, username);
        }

        public IStore CreateStore()
        {
            return new AppleStore();
        }
    }
}
