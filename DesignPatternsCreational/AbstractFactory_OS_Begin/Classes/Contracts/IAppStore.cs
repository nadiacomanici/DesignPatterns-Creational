using System.Collections.Generic;

namespace AbstractFactory_OS_Begin.Classes.Contracts
{
    public interface IAppStore
    {
        bool Login(IUser user);
        List<string> SearchApp(IUser user, string searchKeyword);
    }
}
