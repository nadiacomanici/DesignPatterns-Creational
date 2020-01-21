using System;

namespace Singleton_ThreadSafe.Classes
{
    public sealed class NotThreadSafeSingleton
    {
        //[ThreadStatic]
        private static NotThreadSafeSingleton _instance;
        private static int _numberOfInstances = 1;
        private readonly int _loggerIndex;

        
        static NotThreadSafeSingleton()
        {
            _instance = new NotThreadSafeSingleton();
            _numberOfInstances++;
        }

        private NotThreadSafeSingleton()
        {
            _loggerIndex = _numberOfInstances;
        }

        public static NotThreadSafeSingleton GetInstance()
        {
            return _instance;
        }

        public void AddMessage(string message)
        {
            Console.WriteLine($"Message written in log {_loggerIndex}: {message}");
        }
    }
}
