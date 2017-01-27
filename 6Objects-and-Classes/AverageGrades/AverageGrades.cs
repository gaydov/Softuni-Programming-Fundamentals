using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            int totalStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int studentNumber = 1; studentNumber <= totalStudents; studentNumber++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                Student currentStudent = new Student();
                currentStudent.name = name;
                currentStudent.grades = new List<double>();

                // Filling the student's grades:
                for (int grade = 1; grade < input.Length; grade++)
                {
                    currentStudent.grades.Add(double.Parse(input[grade]));
                }
                students.Add(currentStudent);
            }

            foreach (Student student in students
                .Where(student => student.avgGrade >= 5.00)
                .OrderBy(student => student.name)
                .ThenByDescending(s => s.avgGrade))
            {
                Console.WriteLine("{0} -> {1:F2}", student.name, student.avgGrade);
            }
        }
    }

    public class Student
    {
        public string name { get; set; }
        public List<double> grades { get; set; }
        public double avgGrade
        {
            get
            {
                return grades.Average();
            }
        }
    }
}
