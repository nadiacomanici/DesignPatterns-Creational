using System;
using AbstractFactory_OS_Demo.Classes.Apple;
using AbstractFactory_OS_Demo.Classes.Contract;
using AbstractFactory_OS_Demo.Classes.Windows;

namespace AbstractFactory_OS_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlatformFactory factory = new AppleFactory("001", "alin");
            var device = new Device(factory.CreateAccount(),factory.CreateStore());
            device.LogIntoAppStore();
            device.ResetUserPassword();
            foreach (var result in device.SearchForApp("notepad"))
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();
        }
    }
}
