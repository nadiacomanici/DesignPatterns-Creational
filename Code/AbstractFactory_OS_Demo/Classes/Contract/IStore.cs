using System.Collections.Generic;

namespace AbstractFactory_OS_Demo.Classes.Contract
{
    public interface IStore
    {
        bool Login(IAccount userAccount);

        List<string> SearchApp(IAccount userAccount, string searchKeyword);

    }
}
