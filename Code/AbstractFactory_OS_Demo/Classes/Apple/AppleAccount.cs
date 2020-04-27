using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_OS_Demo.Classes.Contract;
using AbstractFactory_OS_Demo.Classes.Windows;

namespace AbstractFactory_OS_Demo.Classes.Apple
{
    public class AppleAccount:IAccount
    {

        public string ID { get; private set; }

        public string Username { get; private set; }

        public string Email
        {
            get
            {
                return $"{Username}@apple.com";
            }
        }

        public AppleAccount(string id, string username)
        {
            ID = id;
            Username = username;
        }

        public void ResetPassword()
        {
            Console.WriteLine($"Reset password email was sent to: {Email}");
        }
    }
}
