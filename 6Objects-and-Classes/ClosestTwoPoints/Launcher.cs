using System;
using System.Linq;

namespace ClosestTwoPoints
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                points[i] = new Point
                {
                    X = input[0],
                    Y = input[1]
                };
            }

            Point[] closestPoints = FindClosestTwoPoints(points);
            double minimalDistance = CalcDistance(closestPoints[0], closestPoints[1]);

            PrintResults(closestPoints, minimalDistance);
        }

        public static void PrintResults(Point[] closestPoints, double minimalDistance)
        {
            Console.WriteLine(minimalDistance.ToString("0.000"));

            foreach (Point point in closestPoints)
            {
                Console.WriteLine("({0}, {1})", point.X, point.Y);
            }
        }

        public static Point[] FindClosestTwoPoints(Point[] points)
        {
            Point[] closestPoints = new Point[2];
            double minDistance = double.MaxValue;

            for (int firstPoint = 0; firstPoint < points.Length; firstPoint++)
            {
                for (int secondPoint = firstPoint + 1; secondPoint < points.Length; secondPoint++)
                {
                    double distance = CalcDistance(points[firstPoint], points[secondPoint]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints[0] = points[firstPoint];
                        closestPoints[1] = points[secondPoint];
                    }
                }
            }

            return closestPoints;
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double distance = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            return distance;
        }

        public class Point
        {
            public double X { get; set; }

            public double Y { get; set; }
        }
    }
}
