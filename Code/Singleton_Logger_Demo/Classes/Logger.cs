using System;

namespace Singleton_Logger_Demo.Classes
{
    public class Logger
    {
        private static int _numberOfInstances = 1;
        private int _loggerIndex;

        public Logger()
        {
            _loggerIndex = _numberOfInstances;
            _numberOfInstances++;
        }

        public void AddMessage(string message)
        {
            Console.WriteLine($"Message written in log {_loggerIndex}: {message}");
        }
    }
}
