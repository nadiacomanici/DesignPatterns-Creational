using System.Collections.Generic;

namespace AbstractFactory_OS_Demo.Classes.Contracts
{
    public interface IAppStore
    {
        bool Login(IUser user);
        List<string> SearchApp(IUser user, string searchKeyword);
    }
}
