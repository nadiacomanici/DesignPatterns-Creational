using System;

namespace Singleton_ThreadSafe.Classes
{
    public sealed class ThreadSafeSingletonOptimized
    {
        private static ThreadSafeSingletonOptimized _instance;
        private static int _numberOfInstances = 1;
        private readonly int _loggerIndex;

        private ThreadSafeSingletonOptimized()
        {
            _loggerIndex = _numberOfInstances;
            _numberOfInstances++;
        }

        public static ThreadSafeSingletonOptimized GetInstance()
        {
            return Nested.instance;
        }

        public void AddMessage(string message)
        {
            Console.WriteLine($"Message written in log {_loggerIndex}: {message}");
        }

        private class Nested
        {
            // if you specify the static constructor, this type will be initialized lazy
            static Nested()
            {
            }

            internal static readonly ThreadSafeSingletonOptimized instance = new ThreadSafeSingletonOptimized();
        }
    }
}
