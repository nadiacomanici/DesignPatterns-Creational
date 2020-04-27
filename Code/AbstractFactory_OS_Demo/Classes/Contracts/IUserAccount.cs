namespace AbstractFactory_OS_Demo.Classes.Contracts
{
    public interface IUserAccount
    {
        string ID { get; }
        string Username { get; }
        string Email { get; }
        void ResetPassword();
    }
}
