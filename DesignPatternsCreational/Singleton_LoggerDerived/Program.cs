using System;
using Singleton_LoggerDerived.Classes;

namespace Singleton_LoggerDerived
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                University university = new University(Logger.GetInstance());
                university.AddStudent("Nadia", "Comanici");
                university.AddStudent("Ion", "Popescu");
                university.DeleteStudentById(1);
                university.DeleteStudentById(10);
            }
            catch (Exception ex)
            {
                var fileLogger = new DerivedLogger();
                fileLogger.AddMessage(ex.Message);
            }
        }
    }
}
