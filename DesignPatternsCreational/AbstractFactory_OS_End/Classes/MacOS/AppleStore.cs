using System;
using System.Collections.Generic;
using AbstractFactory_OS_End.Classes.Contracts;

namespace AbstractFactory_OS_End.Classes.MacOS
{
    public class AppleStore : IAppStore
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
                $"App {searchKeyword}1 found on apple store for user with appleId={user.Username}",
                $"App {searchKeyword}2 found on apple store for user with appleId={user.Username}",
                $"App {searchKeyword}3 found on apple store for user with appleId={user.Username}"
            };
        }
    }
}
