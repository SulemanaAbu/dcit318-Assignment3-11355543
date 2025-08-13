using System.Collections.Generic;
using Q4_SchoolGradingSystem.Models;

namespace Q4_SchoolGradingSystem.Repositories
{
    public class StudentRepository
    {
        private readonly List<Student> _students = new List<Student>();

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public List<Student> GetAll()
        {
            return new List<Student>(_students);
        }
    }
}