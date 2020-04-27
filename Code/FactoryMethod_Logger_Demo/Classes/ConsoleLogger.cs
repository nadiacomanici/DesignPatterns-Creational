namespace FactoryMethod_Logger_Demo.Classes
{
    public class ConsoleLogger : Logger
    {
        public override ILogSource LogSource
        {
            get
            {
                return new ConsoleLogSource();
            }
        }
    }
}
