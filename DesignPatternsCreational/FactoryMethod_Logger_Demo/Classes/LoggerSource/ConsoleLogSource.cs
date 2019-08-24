using System;

namespace FactoryMethod_Logger_Demo.Classes.LoggerSource
{
    public class ConsoleLogSource : ILogSource
    {
        public void AddMessage(MessageType messageType, string message)
        {
            Console.WriteLine($"{messageType}: {message}");
        }
    }
}
