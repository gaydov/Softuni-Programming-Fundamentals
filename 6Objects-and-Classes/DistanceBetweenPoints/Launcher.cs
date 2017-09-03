using System;
using System.Linq;

namespace DistanceBetweenPoints
{
    public class Launcher
    {
        public static void Main()
        {
            double[] inputP1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] inputP2 = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point point1 = new Point
            {
                X = inputP1[0],
                Y = inputP1[1]
            };

            Point point2 = new Point
            {
                X = inputP2[0],
                Y = inputP2[1]
            };

            double distance = CalcDistance(point1, point2);
            Console.WriteLine("{0:F3}", distance);
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double distance = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            return distance;
        }
    }

    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }
    }
}
