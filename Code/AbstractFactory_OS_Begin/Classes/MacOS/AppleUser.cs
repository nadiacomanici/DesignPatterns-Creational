using AbstractFactory_OS_Begin.Classes.Contracts;

namespace AbstractFactory_OS_Begin.Classes.MacOS
{
    public class AppleUser : IUser
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
        public AppleUser(string id, string username)
        {
            ID = id;
            Username = username;
        }

        public void ResetPassword()
        {
            // TODO: send email with reset password link to apple website
        }
    }
}
