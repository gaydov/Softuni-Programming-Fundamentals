using System;

namespace EmployeeData
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            string firstName = "Amanda";
            Console.WriteLine("First name: {0}", firstName);

            string lastName = "Jonson";
            Console.WriteLine("Last name: {0}", lastName);

            sbyte age = 27;
            Console.WriteLine("Age: {0}", age);

            char gender = 'f';
            Console.WriteLine("Gender: {0}", gender);

            long personalID = 8306112507;
            Console.WriteLine("Personal ID: {0}", personalID);

            uint employeeNum = 27563571;
            Console.WriteLine("Unique Employee number: {0}", employeeNum);
        }
    }
}
