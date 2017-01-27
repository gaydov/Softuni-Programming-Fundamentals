using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGroups
{
    public class StudentGroups
    {
        public static void Main()
        {
            List<Town> townsDatabase = ReadTownsAndStudents();

            List<Group> groupsDatabase = StudentsIntoGroups(townsDatabase);

            PrintingResults(groupsDatabase);
        }
        public static void PrintingResults(List<Group> groups)
        {
            int countTowns = groups.Select(g => g.Town).Distinct().Count();
            Console.WriteLine($"Created {groups.Count} groups in {countTowns} towns:");

            foreach (Group group in groups.OrderBy(g => g.Town.Name))
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(s => s.Email))}");
            }
        }
        public static List<Town> ReadTownsAndStudents()
        {
            List<Town> towns = new List<Town>();

            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                if (input.Contains("=>"))
                {
                    string[] townAndSeatsCount = input.Split(new char[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string nameOfTown = "";
                    int seatsCount = 0;

                    if (townAndSeatsCount.Length > 3) // If the town's name is 2 words long
                    {
                        nameOfTown = townAndSeatsCount[0] + ' ' + townAndSeatsCount[1];
                        seatsCount = int.Parse(townAndSeatsCount[2]);
                    }
                    else
                    {
                        nameOfTown = townAndSeatsCount[0];
                        seatsCount = int.Parse(townAndSeatsCount[1]);
                    }

                    Town currentTown = new Town();
                    currentTown.Name = nameOfTown;
                    currentTown.SeatsCount = seatsCount;
                    currentTown.Students = new List<Student>();
                    towns.Add(currentTown);
                }
                else
                {
                    string[] studentNameEmailDate = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Student currentStudent = new Student();
                    currentStudent.Name = studentNameEmailDate[0] + ' ' + studentNameEmailDate[1];
                    currentStudent.Email = studentNameEmailDate[2];
                    currentStudent.RegistrationDate = DateTime.ParseExact(studentNameEmailDate[3], "d-MMM-yyyy", null);
                    towns.Last().Students.Add(currentStudent);
                }

                input = Console.ReadLine();
            }

            return towns;
        }

        public static List<Group> StudentsIntoGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            foreach (Town town in towns.OrderBy(t => t.Name))
            {
                IEnumerable<Student> students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);

                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    public class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    public class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
