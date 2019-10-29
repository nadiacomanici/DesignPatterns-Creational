using System;
using System.IO;
using FactoryMethod_Logger_Begin.Classes;

namespace FactoryMethod_Logger_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            string logFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FactoryMethod", "log.txt");
            var logger = new Logger(logFile);
            logger.AddError("Error at line 45");
            logger.AddError("Error at line 123");
            logger.AddInfo("Info: Rename this method");
        }
    }
}
