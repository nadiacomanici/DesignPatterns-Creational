using System;

namespace Singleton_Logger_Demo.Classes
{
    public sealed class Logger
    {
        private static int _numberOfInstances = 1;
        private int _loggerIndex;
        public static int SomethingSomething = 42;

        private static Logger _instance;

        private Logger()
        {
            _loggerIndex = _numberOfInstances;
            _numberOfInstances++;
        }

        static Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void AddMessage(string message)
        {
            Console.WriteLine($"Message written in log {_loggerIndex}: {message}");
        }
    }
}
