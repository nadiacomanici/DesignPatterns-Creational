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
            foreach(var result in winDevice.SearchForApp("notepad"))
            {
                Console.WriteLine(result);
            }

            var appleDevice = new AppleDevice();
            appleDevice.LogIntoAppStore();
            foreach (var result in appleDevice.SearchForApp("texteditor"))
            {
                Console.WriteLine(result);
            }
        }
    }
}
