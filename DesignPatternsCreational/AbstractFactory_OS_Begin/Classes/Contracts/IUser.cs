namespace AbstractFactory_OS_Begin.Classes.Contracts
{
    public interface IUser
    {
        string ID { get; }
        string Username { get; }
        string Email { get; }
        void ResetPassword();
    }
}
