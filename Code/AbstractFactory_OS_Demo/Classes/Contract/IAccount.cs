namespace AbstractFactory_OS_Demo.Classes.Contract
{
    public interface IAccount
    {
        string Username { get;}
        string Email { get;}
        void ResetPassword();
    }
}
