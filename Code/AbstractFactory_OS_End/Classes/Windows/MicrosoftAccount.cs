using System;
using AbstractFactory_OS_End.Classes.Contracts;

namespace AbstractFactory_OS_End.Classes.Windows
{
    public class MicrosoftAccount : IUserAccount
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
