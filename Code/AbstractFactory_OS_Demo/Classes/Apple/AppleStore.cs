using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_OS_Demo.Classes.Contract;
using AbstractFactory_OS_Demo.Classes.Windows;

namespace AbstractFactory_OS_Demo.Classes.Apple
{
    public class AppleStore : IStore
    {
        public bool Login(IAccount userAccount)
        {
            Console.WriteLine($"Login into AppStore for user with email {userAccount.Email}");
            return true;
        }

        public List<string> SearchApp(IAccount userAccount, string searchKeyword)
        {
            return new List<string>()
            {
                $"App {searchKeyword}1 found on AppStore store for user with windows account={userAccount.Username}",
                $"App {searchKeyword}2 found on AppStore store for user with windows account={userAccount.Username}"
            };
        }
    }
}
