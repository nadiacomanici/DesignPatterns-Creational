using System;

namespace FactoryMethod_Logger_Demo.Classes
{
    public class ConsoleLogSource : ILogSource
    {
        public void AddMessage(MessageType messageType, string message)
        {
            Console.WriteLine($"Write {messageType} in file: {message}");
        }
    }
}
