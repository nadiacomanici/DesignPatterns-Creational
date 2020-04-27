using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Logger_Demo.Classes
{
    public class ConsoleLogSource : ILogSource
    {
        public void AddMessage(MessageType messageType, string message)
        {
            Console.WriteLine($"{messageType} - {message}");
        }
    }
}
