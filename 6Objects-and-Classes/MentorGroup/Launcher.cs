using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup
{
    public class Launcher
    {
        public static void Main()
        {
            SortedDictionary<string, Student> groupOfStudents = new SortedDictionary<string, Student>();

            string inputDates = Console.ReadLine();
            AddAttendaceDates(groupOfStudents, inputDates);

            string inputComments = Console.ReadLine();
            AddCommentsForStudents(groupOfStudents, inputComments);

            PrintingResults(groupOfStudents);
        }

        public static void PrintingResults(SortedDictionary<string, Student> group)
        {
            foreach (KeyValuePair<string, Student> student in group)
            {
                Console.WriteLine($"{student.Key}");

                Console.WriteLine("Comments:");
                foreach (string comment in group[student.Key].Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (DateTime date in group[student.Key].DatesAttended.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }

        public static void AddCommentsForStudents(SortedDictionary<string, Student> group, string input)
        {
            while (!input.Equals("end of comments"))
            {
                string[] commentsArgs = input.Split('-');
                string studentName = commentsArgs[0];

                if (!group.ContainsKey(studentName))
                {
                    input = Console.ReadLine();
                    continue;
                }

                // If there is at least one comment
                if (commentsArgs.Length > 1)
                {
                    string comments = commentsArgs[1];

                    group[studentName].Comments.Add(comments);
                }

                input = Console.ReadLine();
            }
        }

        public static void AddAttendaceDates(SortedDictionary<string, Student> group, string input)
        {
            while (!input.Equals("end of dates"))
            {
                string[] inputParams = input.Split();
                string studentName = inputParams[0];

                // If there is at least one attendance date for that student
                if (inputParams.Length > 1) 
                {
                    List<DateTime> dates = inputParams[1].Split(',')
                        .Select(date => DateTime
                        .ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                        .ToList();

                    if (!group.ContainsKey(studentName))
                    {
                        group.Add(studentName, new Student());
                        group[studentName].Comments = new List<string>();
                        group[studentName].DatesAttended = new List<DateTime>();
                        group[studentName].Name = studentName;
                        group[studentName].DatesAttended.AddRange(dates);
                    }
                    else
                    {
                        group[studentName].DatesAttended.AddRange(dates);
                    }
                }
                else 
                {
                    // If there is no date after the student's name we only add the student to the dictionary:
                    if (!group.ContainsKey(studentName))
                    {
                        group.Add(studentName, new Student());
                        group[studentName].Comments = new List<string>();
                        group[studentName].DatesAttended = new List<DateTime>();
                        group[studentName].Name = studentName;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public List<DateTime> DatesAttended { get; set; }

        public List<string> Comments { get; set; }
    }
}
