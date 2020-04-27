using System;
using AbstractFactory_OS_Demo.Classes.Contract;

namespace AbstractFactory_OS_Demo.Classes.Windows
{
    public class MicrosoftAccount:IAccount
    {
        public string ID { get; private set; }

        public string Username { get; private set; }

        public string Email
        {
            get
            {
                return $"{Username}@microsoft.com";
            }
        }

        public MicrosoftAccount(string id, string username)
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
