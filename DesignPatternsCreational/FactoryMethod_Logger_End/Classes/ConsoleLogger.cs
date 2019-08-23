namespace FactoryMethod_Logger_End.Classes
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
