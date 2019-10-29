namespace FactoryMethod_Logger_Demo.Classes
{
    public class ConsoleLogger : Logger
    {
        protected override ILogSource LogSource => new ConsoleLogSource();
    }
}
