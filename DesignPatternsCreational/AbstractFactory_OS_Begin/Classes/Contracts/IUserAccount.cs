namespace AbstractFactory_OS_Begin.Classes.Contracts
{
    public interface IUserAccount
    {
        string ID { get; }
        string Username { get; }
        string Email { get; }
        void ResetPassword();
    }
}
