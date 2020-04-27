namespace FactoryMethod_Logger_End.Classes
{
    public interface ILogSource
    {
        void AddMessage(MessageType messageType, string message);
    }
}
