using System;

namespace Singleton_LoggerDerived.Classes
{
    public class Logger
    {
        private static int _numberOfInstances = 1;
        private static Logger _instance;
        private readonly int _loggerIndex;

        protected Logger()
        {
            _loggerIndex = _numberOfInstances;
            _numberOfInstances++;
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public virtual void AddMessage(string message)
        {
            Console.WriteLine($"Message written in log {_loggerIndex}: {message}");
        }
    }
}
