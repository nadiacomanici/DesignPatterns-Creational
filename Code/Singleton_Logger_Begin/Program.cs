using System;
using Singleton_Logger_Begin.Classes;

namespace Singleton_Logger_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            try
            {
                University university = new University();
                university.AddStudent("Nadia", "Comanici");
                university.AddStudent("Ion", "Popescu");
                university.DeleteStudentById(1);
                university.DeleteStudentById(10);
            }
            catch (Exception ex)
            {
                logger.AddMessage(ex.Message);
            }
        }
    }
}
