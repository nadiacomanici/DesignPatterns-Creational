using System;
using AbstractFactory_OS_End.Classes.MacOS;
using AbstractFactory_OS_End.Classes.Windows;

namespace AbstractFactory_OS_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var winDevice = new Device(new MicrosoftFactory("1234", "nadiac"));
            winDevice.LogIntoAppStore();
            winDevice.ResetUserPassword();
            foreach (var result in winDevice.SearchForApp("notepad"))
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();

            var appleDevice = new Device(new AppleFactory("5667", "ncomanici"));
            appleDevice.LogIntoAppStore();
            appleDevice.ResetUserPassword();
            foreach (var result in appleDevice.SearchForApp("texteditor"))
            {
                Console.WriteLine(result);
            }
        }
    }
}
