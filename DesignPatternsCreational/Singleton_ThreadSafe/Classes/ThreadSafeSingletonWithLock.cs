using System;

namespace Singleton_ThreadSafe.Classes
{
    public sealed class ThreadSafeSingletonWithLock
    {
        private static ThreadSafeSingletonWithLock _instance;
        private static int _numberOfInstances = 1;
        private static readonly object instanceLock = new object();
        private readonly int _loggerIndex;

        private ThreadSafeSingletonWithLock()
        {
            _loggerIndex = _numberOfInstances;
            _numberOfInstances++;
        }

        public static ThreadSafeSingletonWithLock GetInstance()
        {
            lock (instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingletonWithLock();
                }
                return _instance;
            }
        }

        public void AddMessage(string message)
        {
            Console.WriteLine($"Message written in log {_loggerIndex}: {message}");
        }
    }
}
