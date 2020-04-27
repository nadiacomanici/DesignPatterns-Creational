namespace FactoryMethod_Logger_End.Classes
{
    public class FileLogger : Logger
    {
        private readonly string _fullFilePath;
        private FileLogSource _fileLogSource;
        
        public FileLogger(string fullFilePath)
        {
            _fullFilePath = fullFilePath;
        }

        protected override ILogSource LogSource
        {
            get
            {
                if (_fileLogSource == null)
                {
                    _fileLogSource = new FileLogSource(_fullFilePath);
                }
                return _fileLogSource;
            }
        }
    }
}
