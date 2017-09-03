using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    public class Launcher
    {
        public static void Main()
        {
            int totalStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int studentNumber = 1; studentNumber <= totalStudents; studentNumber++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                Student currentStudent = new Student
                {
                    Name = name,
                    Grades = new List<double>()
                };

                // Filling the student's grades:
                for (int grade = 1; grade < input.Length; grade++)
                {
                    currentStudent.Grades.Add(double.Parse(input[grade]));
                }

                students.Add(currentStudent);
            }

            foreach (Student student in students
                .Where(student => student.AvgGrade >= 5.00)
                .OrderBy(student => student.Name)
                .ThenByDescending(s => s.AvgGrade))
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name, student.AvgGrade);
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AvgGrade
        {
            get
            {
                return this.Grades.Average();
            }
        }
    }
}
