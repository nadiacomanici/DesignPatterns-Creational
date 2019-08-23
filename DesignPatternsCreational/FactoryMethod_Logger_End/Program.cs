using FactoryMethod_Logger_End.Classes;

namespace FactoryMethod_Logger_End
{
    class Program
    {
        static void Main(string[] args)
        {
            //string logFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FactoryMethod", "log.txt");
            //var logger = new FileLogger(logFile);
            var logger = new ConsoleLogger();
            logger.AddError("Error at line 45");
            logger.AddError("Error at line 123");
            logger.AddInfo("Info: Rename this method");
        }
    }
}
