using System;
using System.Collections.Generic;
using AbstractFactory_OS_Demo.Classes.Contract;

namespace AbstractFactory_OS_Demo.Classes.Windows
{
    public class WindowsStore :IStore
    {
        public bool Login(IAccount userAccount)
        {
            Console.WriteLine($"Login into WindowsStore for user with email {userAccount.Email}");
            return true;
        }

        public List<string> SearchApp(IAccount userAccount, string searchKeyword)
        {
            return new List<string>()
            {
                $"App {searchKeyword}1 found on WindowsStore for user with windows account={userAccount.Username}",
                $"App {searchKeyword}2 found on WindowsStore for user with windows account={userAccount.Username}"
            };
        }
    }
}
