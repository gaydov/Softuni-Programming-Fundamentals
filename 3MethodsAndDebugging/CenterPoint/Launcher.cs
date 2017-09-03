using System;

namespace CenterPoint
{
    public class Launcher
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintPointClosestToCenter(x1, y1, x2, y2);
            Console.WriteLine();
        }

        private static void PrintPointClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double distancePoint1 = Math.Sqrt(Math.Pow(x1 - 0, 2) + Math.Pow(y1 - 0, 2));
            double distancePoint2 = Math.Sqrt(Math.Pow(x2 - 0, 2) + Math.Pow(y2 - 0, 2));

            if (distancePoint1 < distancePoint2)
            {
                Console.Write("({0}, {1})", x1, y1);
            }
            else
            {
                Console.Write("({0}, {1})", x2, y2);
            }
        }
    }
}
