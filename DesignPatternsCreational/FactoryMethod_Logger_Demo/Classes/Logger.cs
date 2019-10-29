namespace FactoryMethod_Logger_Demo.Classes
{
    public abstract class Logger
    {
        abstract protected ILogSource LogSource { get; }

        public Logger()
        {
        }

        public void AddError(string errorMessage)
        {
            LogSource.AddMessage(MessageType.Error, errorMessage);
        }

        public void AddInfo(string message)
        {
            LogSource.AddMessage(MessageType.Info, message);
        }
    }
}
