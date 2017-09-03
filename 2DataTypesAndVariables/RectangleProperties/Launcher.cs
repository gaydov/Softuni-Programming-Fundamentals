using System;

namespace RectangleProperties
{
    public class Launcher
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double perimeter = (2 * a) + (2 * b);
            double area = a * b;
            double diagonal = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
