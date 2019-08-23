using System;
using Singleton_Logger_End.Classes;

namespace Singleton_Logger_End
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
