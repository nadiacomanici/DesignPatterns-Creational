namespace FactoryMethod_Logger_Demo.Classes
{
    public class FileLogger : Logger
    {
        private string fileFullPath;

        public FileLogger(string fileFullPath)
        {
            this.fileFullPath = fileFullPath;
        }

        public override ILogSource LogSource
        {
            get
            {
                return new FileLogSource(fileFullPath);
            }
        }
    }
}
