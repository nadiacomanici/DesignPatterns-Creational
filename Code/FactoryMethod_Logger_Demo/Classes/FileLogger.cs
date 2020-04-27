namespace FactoryMethod_Logger_Demo.Classes
{
    public class FileLogger : Logger
    {
        private readonly string FilePath;

        public FileLogger(string filePath)
        {
            FilePath = filePath;
        }

        protected override ILogSource LogSource => new FileLogSource(FilePath);
    }
}
