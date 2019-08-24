using FactoryMethod_Logger_Demo.Classes.LoggerSource;

namespace FactoryMethod_Logger_Demo.Classes.Loggers
{
    public class ConsoleLogger : Logger
    {
        protected override ILogSource LogSource
        {
            get
            {
                return new ConsoleLogSource();
            }
        }
    }
}
