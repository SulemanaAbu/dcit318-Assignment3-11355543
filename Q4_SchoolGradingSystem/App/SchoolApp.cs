using System;
using Q4_SchoolGradingSystem.Models;
using Q4_SchoolGradingSystem.Repositories;

namespace Q4_SchoolGradingSystem.App
{
    public class SchoolApp
    {
        private readonly StudentRepository _repo = new StudentRepository();

        public void SeedData()
        {
            Student s1 = new Student(1, "Alice");
            s1.AddGrade(new Grade("Math", 85));
            s1.AddGrade(new Grade("English", 90));

            Student s2 = new Student(2, "Bob");
            s2.AddGrade(new Grade("Math", 75));
            s2.AddGrade(new Grade("English", 80));

            Student s3 = new Student(3, "Charlie");
            s3.AddGrade(new Grade("Math", 92));
            s3.AddGrade(new Grade("English", 88));

            _repo.Add(s1);
            _repo.Add(s2);
            _repo.Add(s3);
        }

        public void PrintAllStudents()
        {
            Console.WriteLine("\nStudent Grades:");
            foreach (var student in _repo.GetAll())
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}