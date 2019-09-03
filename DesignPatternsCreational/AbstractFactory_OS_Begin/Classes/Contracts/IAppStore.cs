using System.Collections.Generic;

namespace AbstractFactory_OS_Begin.Classes.Contracts
{
    public interface IAppStore
    {
        bool Login(IUserAccount userAccount);

        List<string> SearchApp(IUserAccount userAccount, string searchKeyword);
    }
}
