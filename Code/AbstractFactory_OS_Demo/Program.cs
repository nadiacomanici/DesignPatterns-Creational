using System;
using AbstractFactory_OS_Demo.Classes.Common;
using AbstractFactory_OS_Demo.Classes.MacOS;
using AbstractFactory_OS_Demo.Classes.Windows;

namespace AbstractFactory_OS_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var winDevice = new Device(new WindowsFactory("1234", "nadiac"));
            winDevice.LogIntoAppStore();
            foreach(var result in winDevice.SearchForApp("notepad"))
            {
                Console.WriteLine(result);
            }

            var appleDevice = new Device(new AppleFactory("1004", "jbanu"));
            appleDevice.LogIntoAppStore();
            foreach (var result in appleDevice.SearchForApp("texteditor"))
            {
                Console.WriteLine(result);
            }
        }
    }
}
