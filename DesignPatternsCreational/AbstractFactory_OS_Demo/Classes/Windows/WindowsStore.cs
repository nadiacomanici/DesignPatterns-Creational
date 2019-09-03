using System;
using System.Collections.Generic;
using AbstractFactory_OS_Demo.Classes.Contracts;

namespace AbstractFactory_OS_Demo.Classes.Windows
{
    public class WindowsStore : IAppStore
    {
        public bool Login(IUser user)
        {
            Console.WriteLine($"Login for user with email {user.Email}");
            return true;
        }

        public List<string> SearchApp(IUser user, string searchKeyword)
        {
            return new List<string>()
            {
                $"App {searchKeyword}1 found on windows store for user with windows account={user.Username}",
                $"App {searchKeyword}2 found on windows store for user with windows account={user.Username}"
            };
        }
    }
}
