using System;
using Singleton_Logger_Begin.Classes;

namespace Singleton_Logger_Begin
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
                Logger.GetInstance().AddMessage(ex.Message);
            }
        }
    }
}
