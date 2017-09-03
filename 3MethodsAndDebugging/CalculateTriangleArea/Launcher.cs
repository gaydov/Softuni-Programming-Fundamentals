using System;

namespace CalculateTriangleArea
{
    public class Launcher
    {
        public static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double triangleArea = CalcTriangleArea(height, b);
            Console.WriteLine(triangleArea);
        }

        public static double CalcTriangleArea(double height, double b)
        {
            double area = (height * b) / 2;
            return area;
        }
    }
}
