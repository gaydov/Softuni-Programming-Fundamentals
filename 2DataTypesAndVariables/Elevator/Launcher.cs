using System;

namespace Elevator
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(people / (double)capacity);
            Console.WriteLine(courses);
        }
    }
}
