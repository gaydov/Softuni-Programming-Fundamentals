using System;
using System.Linq;

namespace CirclesIntersection
{
    public class CirclesIntersection
    {
        public static void Main()
        {
            double[] firstCircleArgs = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle firstCircle = new Circle();
            firstCircle.center.X = firstCircleArgs[0];
            firstCircle.center.Y = firstCircleArgs[1];
            firstCircle.radius = firstCircleArgs[2];

            double[] secondCircleArgs = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle secondCircle = new Circle();
            secondCircle.center.X = secondCircleArgs[0];
            secondCircle.center.Y = secondCircleArgs[1];
            secondCircle.radius = secondCircleArgs[2];

            if (DoIntersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool DoIntersect(Circle c1, Circle c2)
        {
            double distance = CalcDistance(c1.center, c2.center);

            if (distance <= c1.radius + c2.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double CalcDistance(Circle.Point c1Center, Circle.Point c2Center)
        {
            double distance = Math.Sqrt(Math.Pow((c1Center.X - c2Center.X), 2) + Math.Pow((c1Center.Y - c2Center.Y), 2));
            return distance;
        }
    }
    public class Circle
    {
        public Point center = new Point();
        public double radius { get; set; }
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
