namespace FactoryMethod_Logger_Begin.Classes
{
    public class Logger
    {
        protected FileLogSource LogSource { get; }

        public Logger(string fullFilePath)
        {
            LogSource = new FileLogSource(fullFilePath);
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
