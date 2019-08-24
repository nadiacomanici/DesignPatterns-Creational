namespace FactoryMethod_Logger_Demo.Classes
{
    public abstract class Logger
    {
        protected abstract ILogSource LogSource { get; }

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
