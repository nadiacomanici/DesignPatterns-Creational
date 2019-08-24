namespace FactoryMethod_Logger_Demo.Classes
{
    public class FileLogger : Logger
    {
        private string _fullFilePath;

        public FileLogger(string fullFilePath)
        {
            _fullFilePath = fullFilePath;
        }

        protected override ILogSource LogSource
        {
            get
            {
                return new FileLogSource(_fullFilePath);
            }
        }
    }
}
