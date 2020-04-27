using AbstractFactory_OS_Demo.Classes.Windows;

namespace AbstractFactory_OS_Demo.Classes.Contract
{
    public interface IPlatformFactory
    {
        IAccount CreateAccount();
        IStore CreateStore();
    }
}
