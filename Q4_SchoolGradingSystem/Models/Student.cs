using System;
using System.Collections.Generic;
using Q4_SchoolGradingSystem.Interfaces;

namespace Q4_SchoolGradingSystem.Models
{
    public class Student : IGradable
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private List<Grade> Grades;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Grades = new List<Grade>();
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

        public double GetAverageGrade()
        {
            if (Grades.Count == 0) return 0;

            double sum = 0;
            for (int i = 0; i < Grades.Count; i++)
            {
                sum += Grades[i].Score;
            }
            return sum / Grades.Count;
        }

        public string GetLetterGrade()
        {
            double avg = GetAverageGrade();
            if (avg >= 90) return "A";
            if (avg >= 80) return "B";
            if (avg >= 70) return "C";
            if (avg >= 60) return "D";
            return "F";
        }

        public override string ToString()
        {
            return Id + ": " + Name + " | Average: " + GetAverageGrade() + " | Grade: " + GetLetterGrade();
        }
    }
}