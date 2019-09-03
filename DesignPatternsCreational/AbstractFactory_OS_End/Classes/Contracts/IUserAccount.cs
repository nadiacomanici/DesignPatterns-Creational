namespace AbstractFactory_OS_End.Classes.Contracts
{
    public interface IUserAccount
    {
        string ID { get; }
        string Username { get; }
        string Email { get; }
        void ResetPassword();
    }
}
