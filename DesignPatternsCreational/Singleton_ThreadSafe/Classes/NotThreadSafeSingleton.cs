using System;

namespace Singleton_ThreadSafe.Classes
{
    public sealed class NotThreadSafeSingleton
    {
        private static NotThreadSafeSingleton _instance;
        private static int _numberOfInstances = 1;
        private readonly int _loggerIndex;

        private NotThreadSafeSingleton()
        {
            _loggerIndex = _numberOfInstances;
            _numberOfInstances++;
        }

        public static NotThreadSafeSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NotThreadSafeSingleton();
            }
            return _instance;
        }

        public void AddMessage(string message)
        {
            Console.WriteLine($"Message written in log {_loggerIndex}: {message}");
        }
    }
}
