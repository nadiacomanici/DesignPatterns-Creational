using System;
using System.Collections.Generic;
using AbstractFactory_OS_Begin.Classes.Contracts;

namespace AbstractFactory_OS_Begin.Classes.Windows
{
    public class WindowsStore : IAppStore
    {
        public bool Login(IUserAccount userAccount)
        {
            Console.WriteLine($"Login for user with email {userAccount.Email}");
            return true;
        }

        public List<string> SearchApp(IUserAccount userAccount, string searchKeyword)
        {
            return new List<string>()
            {
                $"App {searchKeyword}1 found on windows store for user with windows account={userAccount.Username}",
                $"App {searchKeyword}2 found on windows store for user with windows account={userAccount.Username}"
            };
        }
    }
}
