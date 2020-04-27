using System.Collections.Generic;
using System.Linq;

namespace Singleton_Logger_Demo.Classes
{
    public class University
    {
        private int _nextId;
        private List<Student> _students;

        public University()
        {
            _nextId = 1;
            _students = new List<Student>();
        }

        public Student AddStudent(string firstName, string lastName)
        {
            var student = new Student(_nextId++, firstName, lastName);
            _students.Add(student);
            Logger.Instance.AddMessage($"Student added with id={student.Id}");
            return student;
        }

        public bool DeleteStudentById(int studentId)
        {
            Student student = _students.SingleOrDefault(s => s.Id == studentId);
            if (student == null)
            {
                throw new System.Exception($"Student with id={studentId} could not be deleted");
            }
            else
            {
                _students.Remove(student);
                Logger.Instance.AddMessage($"Student with id={studentId} was deleted");
                return true;
            }
        }
    }
}
