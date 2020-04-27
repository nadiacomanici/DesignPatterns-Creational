namespace FactoryMethod_Logger_Demo.Classes
{
    public interface ILogSource
    {
        void AddMessage(MessageType messageType, string message);
    }
}