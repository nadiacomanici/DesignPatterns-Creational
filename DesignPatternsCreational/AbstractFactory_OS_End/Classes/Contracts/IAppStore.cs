using System.Collections.Generic;

namespace AbstractFactory_OS_End.Classes.Contracts
{
    public interface IAppStore
    {
        bool Login(IUser user);
        List<string> SearchApp(IUser user, string searchKeyword);
    }
}
