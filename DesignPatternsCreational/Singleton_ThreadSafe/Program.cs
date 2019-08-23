using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Singleton_ThreadSafe.Classes;

namespace Singleton_ThreadSafe
{

    class Program
    {
        private static void DoWork_NotThreadSafeSingleton(object parameter)
        {
            for (int i = 0; i < 10; i++)
            {
                NotThreadSafeSingleton.GetInstance().AddMessage($"Thread {parameter}: {i}");
            }
        }

        private static void NotThreadSafeSingletonSample()
        {
            var t1 = new Thread(DoWork_NotThreadSafeSingleton);
            var t2 = new Thread(DoWork_NotThreadSafeSingleton);
            t1.Start(1);
            t2.Start(2);
        }

        private static void DoWork_ThreadSafeSingletonWithLock(object parameter)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadSafeSingletonWithLock.GetInstance().AddMessage($"Thread {parameter}: {i}");
            }
        }

        private static void ThreadSafeSingletonWithLockSample()
        {
            var t1 = new Thread(DoWork_ThreadSafeSingletonWithLock);
            var t2 = new Thread(DoWork_ThreadSafeSingletonWithLock);
            t1.Start(1);
            t2.Start(2);
        }


        private static void DoWork_ThreadSafeSingletonOptimized(object parameter)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadSafeSingletonOptimized.GetInstance().AddMessage($"Thread {parameter}: {i}");
            }
        }

        private static void ThreadSafeSingletonOptimizedSample()
        {
            var t1 = new Thread(DoWork_ThreadSafeSingletonOptimized);
            var t2 = new Thread(DoWork_ThreadSafeSingletonOptimized);
            t1.Start(1);
            t2.Start(2);
        }

        static void Main(string[] args)
        {
            NotThreadSafeSingletonSample();
            ThreadSafeSingletonWithLockSample();
            ThreadSafeSingletonOptimizedSample();
        }
    }
}
