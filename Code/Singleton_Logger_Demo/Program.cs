using System;
using Singleton_Logger_Demo.Classes;

namespace Singleton_Logger_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var loggernr = Logger._numberOfInstances;

                University university = new University();
                university.AddStudent("Nadia", "Comanici");
                university.AddStudent("Ion", "Popescu");
                university.DeleteStudentById(1);
                university.DeleteStudentById(10);
            }
            catch (Exception ex)
            {
                Logger.Instance.AddMessage(ex.Message);
            }
        }
    }
}
