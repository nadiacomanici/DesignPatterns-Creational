using AbstractFactory_OS_End.Classes.Contracts;

namespace AbstractFactory_OS_End.Classes.Windows
{
    public class MicrosoftAccount : IUser
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
            // TODO: send email with reset password link to microsoft website
        }
    }
}
