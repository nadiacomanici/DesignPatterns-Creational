using System;

namespace Singleton_Logger_Demo.Classes
{
    public sealed class Logger
    {
        public static int _numberOfInstances = 1;
        private int _loggerIndex;

        private static Logger _logger;

        public static Logger Instance
        {
            get
            {
                _logger = _logger ?? new Logger(); //lazy loading

                return _logger;
            }
        }

        //static Logger()
        //{
        //    _logger = new Logger();
        //}
        
        private Logger()
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
