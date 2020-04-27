using System;
using AbstractFactory_OS_Begin.Classes.MacOS;
using AbstractFactory_OS_Begin.Classes.Windows;

namespace AbstractFactory_OS_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            var winDevice = new WindowsDevice(new MicrosoftAccount("1234", "nadiac"), new WindowsStore());
            winDevice.LogIntoAppStore();
            winDevice.ResetUserPassword();
            foreach (var result in winDevice.SearchForApp("notepad"))
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();

            var appleDevice = new AppleDevice();
            appleDevice.LogIntoAppStore();
            appleDevice.ResetUserPassword();
            foreach (var result in appleDevice.SearchForApp("texteditor"))
            {
                Console.WriteLine(result);
            }
        }
    }
}
